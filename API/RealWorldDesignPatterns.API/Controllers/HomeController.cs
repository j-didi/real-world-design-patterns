using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealWorldDesignPatterns.Decorator.Contract;
using RealWorldDesignPatterns.Strategy.Contract;
using RealWorldDesignPatterns.Strategy.Factory;

namespace RealWorldDesignPatterns.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("decorator")]
        public async Task<IActionResult> Get(
            [FromQuery] string postalCode,
            [FromServices] IAddressByZipCodeService service
        )
        {
            var query = new AddressByZipCodeQuery(postalCode);
            var result = await service.GetAsync(query);
            return Ok(result);
        }
        
        [HttpGet("strategy")]
        public async Task<IActionResult> Get(
            [FromQuery] ShippingQuery query,
            [FromServices] IShippingStrategyFactory factory
        )
        {
            var service = factory.Create(query.ShippingCompany);
            var result = await service.CalculatePricingAsync(query);
            return Ok(result);
        }
    }
}