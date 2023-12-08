using Bogus;
using Elasticsearch.Net;
using ElasticSearchWebApi.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace ElasticSearchWebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class UsersController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> SeedData()
    {
        for (int i = 0; i < 10000; i++)
        {
            Faker faker = new();
            Context.User user = new()
            {
                Name = faker.Name.FullName(),
                AboutMe = string.Join(" ", faker.Random.WordsArray(100, 3000))
            };
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllWithEfCore()
    {
        var result = await context.Users.ToListAsync();

        return Ok(result.Count());
    }

    [HttpGet("{value}")]
    public IActionResult GetWithEfCore(string value)
    {
        var response = 
            context
            .Users
            .Where(p=> p.AboutMe.ToLower().Contains(value.ToLower()))
            .AsNoTracking()
            .Take(10)
            .ToList();

        return Ok(response);
    }

    [HttpGet]    
    public async Task<IActionResult> SyncToElasticSearch()
    {
        var setting = new ConnectionConfiguration(new Uri("http://localhost:9200"));
        var client = new ElasticLowLevelClient(setting);

        List<User> users = context.Users.AsNoTracking().Take(1).ToList();

        var tasks = new List<Task>();   
                
        foreach (var user in users)
        {
            var response = await client.GetAsync<StringResponse>("users", user.Id.ToString());
            if(response.HttpStatusCode == 404)
            {
                tasks.Add(client.IndexAsync<StringResponse>("users", user.Id.ToString(), PostData.Serializable(new
                {
                    user.Id,
                    user.Name,
                    user.AboutMe
                })));
            }
        }

        await Task.WhenAll(tasks);

        return NoContent();
    }

    [HttpGet("{value}")]
    [EnableQuery]
    public async Task<IActionResult> GetAllWithElasticSearch(string value)
    {
        var setting = new ConnectionConfiguration(new Uri("http://localhost:9200"));
        var client = new ElasticLowLevelClient(setting);

        var response = await client.SearchAsync<StringResponse>("users", PostData.Serializable(new
        {
            query = new
            {
                match = new
                {
                    AboutMe = value
                }
            }
        }));

        var result = JObject.Parse(response.Body);

        var hits = result["hits"]["hits"].ToObject<List<JObject>>();

        List<User> users = new();

        foreach (var hit in hits)
        {
            users.Add(hit["_source"].ToObject<User>());
        }

        return Ok(users);
    }

}
