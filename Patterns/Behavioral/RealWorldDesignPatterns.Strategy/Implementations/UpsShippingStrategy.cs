using System;
using System.Threading.Tasks;
using RealWorldDesignPatterns.Strategy.Contract;

namespace RealWorldDesignPatterns.Strategy.Implementations
{
    public class UpsShippingStrategy: IShippingService
    {
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