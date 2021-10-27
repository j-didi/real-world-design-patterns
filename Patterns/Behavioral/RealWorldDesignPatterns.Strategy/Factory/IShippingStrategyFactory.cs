using RealWorldDesignPatterns.Strategy.Contract;

namespace RealWorldDesignPatterns.Strategy.Factory
{
    public interface IShippingStrategyFactory
    {
        IShippingService Create(EShippingStrategy strategy);
    }
}