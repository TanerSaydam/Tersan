using DependencyInjectionWebApi.Abstractions;
using DependencyInjectionWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionWebApi.Controllers;
public class ValuesController() : ApiController
{

    [HttpGet]
    public IActionResult Get()
    {
        StaticService.SmsGonder();
        //ProductServiceWithMongoDb productService = new ProductServiceWithMongoDb();

        //productService.Add("Hello");
        //oneService.SmsGonder();

        //twoService.MailGonder();

        return NoContent();
    }
}
