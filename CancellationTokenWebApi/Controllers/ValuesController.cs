using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.OData;

namespace CancellationTokenWebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            // Asenkron bir gecikme ekle ve CancellationToken kullan
            await Task.Delay(10000, cancellationToken);
        }
        catch (TaskCanceledException)
        {
            // İptal durumu için özel bir işlem yapılabilir
            return StatusCode(499); // Özel bir durum kodu döndürülebilir
        }

        return NoContent();
    }

    [EnableQuery]
    [HttpGet]
    public List<RemarksGetModel> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = _dataService.GetRemarksMappedQueryable().ToListAsync(cancellationToken);

            return result.Data; //p=> p.Name == "Taner"  
        }
        catch (Exception ex)
        {
            throw new ArgumentException("");
        }        
    }
}
