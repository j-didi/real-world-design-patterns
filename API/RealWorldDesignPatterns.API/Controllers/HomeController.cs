using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealWorldDesignPatterns.Decorator.Contract;

namespace RealWorldDesignPatterns.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get(
            [FromQuery] string postalCode,
            [FromServices] IAddressByZipCodeService service
        )
        {
            var query = new AddressByZipCodeQuery(postalCode);
            var result = await service.GetAsync(query);
            return Ok(result);
        }
    }
}