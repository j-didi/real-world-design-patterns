using System;
using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.Strategy.Contract;
using RealWorldDesignPatterns.Strategy.Implementations;

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
                EShippingStrategy.Ups => GetService(typeof(UpsShippingStrategy)),
                _ => throw new ArgumentOutOfRangeException(nameof(strategy), strategy, null)
            };

        private IShippingService GetService(Type type) =>
            _strategies.FirstOrDefault(e => e.GetType() == type);
    }
}