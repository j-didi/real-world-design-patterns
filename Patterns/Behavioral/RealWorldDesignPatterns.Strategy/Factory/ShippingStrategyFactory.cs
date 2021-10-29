using System;
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
                EShippingStrategy.Fedex => GetService(typeof(FedexShippingStrategy)),
                EShippingStrategy.Dhl => GetService(typeof(DhlShippingStrategy)),
                _ => GetService(typeof(UpsShippingStrategy))
            };

        private IShippingService GetService(Type type) =>
            _strategies.FirstOrDefault(e => e.GetType() == type);
    }
}