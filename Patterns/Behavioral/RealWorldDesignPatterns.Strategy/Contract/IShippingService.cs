using System.Threading.Tasks;

namespace RealWorldDesignPatterns.Strategy.Contract
{
    public interface IShippingService
    {
        Task<ShippingResult> CalculatePricingAsync(ShippingQuery query);
    }
}