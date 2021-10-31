using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealWorldDesignPatterns.Adapter.Contract;
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
        public async Task<IActionResult> GetAddressByZipCode(
            [FromQuery] string postalCode,
            [FromServices] IAddressByZipCodeService service
        )
        {
            var query = new AddressByZipCodeQuery(postalCode);
            var result = await service.GetAsync(query);
            return Ok(result);
        }
        
        [HttpGet("strategy")]
        public async Task<IActionResult> GetShippingPrice(
            [FromQuery] ShippingQuery query,
            [FromServices] IShippingStrategyFactory factory
        )
        {
            var service = factory.Create(query.ShippingCompany);
            var result = await service.CalculatePricingAsync(query);
            return Ok(result);
        }
        
        [HttpGet("adapter")]
        public async Task<ActionResult> GetCharacters(
            [FromServices] IEnumerable<IGetCharactersService> services
        )
        {
            var result = new List<GetCharactersResult>();
            var tasks = services.ToList().Select(async service =>
            {
                var items = await service.GetAsync();
                result.AddRange(items);
            });

            await Task.WhenAll(tasks);

            return Ok(result);
        }
    }
}