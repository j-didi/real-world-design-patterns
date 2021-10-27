using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.Strategy.Contract;
using RealWorldDesignPatterns.Strategy.Strategies;

namespace RealWorldDesignPatterns.Strategy.Factory
{
    public class ShippingStrategyFactory : IShippingStrategyFactory
    {
        private readonly IList<IShippingService> _strategies;

        public ShippingStrategyFactory(IEnumerable<IShippingService> strategies)
        {
            _strategies = strategies.ToList();
        }

        public IShippingService Create(EShippingStrategy strategy) => 
            strategy switch
            {
                EShippingStrategy.Fedex => _strategies.FirstOrDefault(e => e.GetType() == typeof(FedexShippingStrategy)),
                EShippingStrategy.Dhl => _strategies.FirstOrDefault(e => e.GetType() == typeof(DhlShippingStrategy)),
                _ => _strategies.FirstOrDefault(e => e.GetType() == typeof(UpsShippingStrategy))
            };
    }
}