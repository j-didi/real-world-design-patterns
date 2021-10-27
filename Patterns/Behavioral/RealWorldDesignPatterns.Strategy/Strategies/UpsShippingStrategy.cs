using System;
using System.Net.Http;
using System.Threading.Tasks;
using RealWorldDesignPatterns.Strategy.Contract;

namespace RealWorldDesignPatterns.Strategy.Strategies
{
    public class UpsShippingStrategy: IShippingService
    {
        //Only to show DI flow
        private readonly HttpClient _httpClient;

        public UpsShippingStrategy(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public Task<ShippingResult> CalculatePricingAsync(ShippingQuery query)
        {
            Console.WriteLine("Integrating with UPS...");
            
            //Implement integration
            var price = new Random().Next(15);
            var result = new ShippingResult(price);
            return Task.FromResult(result);
        }
    }
}