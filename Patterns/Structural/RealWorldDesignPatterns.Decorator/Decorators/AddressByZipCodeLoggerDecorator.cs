using System;
using System.Text.Json;
using System.Threading.Tasks;
using RealWorldDesignPatterns.Decorator.Contract;

namespace RealWorldDesignPatterns.Decorator.Decorators
{
    public class AddressByZipCodeLoggerDecorator : IAddressByZipCodeService
    {
        private readonly IAddressByZipCodeService _service;

        public AddressByZipCodeLoggerDecorator(IAddressByZipCodeService service)
        {
            _service = service;
        }

        public async Task<AddressByZipCodeResult> GetAsync(AddressByZipCodeQuery query)
        {
            Console.WriteLine(JsonSerializer.Serialize(query));
            var result = await _service.GetAsync(query);
            Console.WriteLine(JsonSerializer.Serialize(result));

            return result;
        }
    }
}