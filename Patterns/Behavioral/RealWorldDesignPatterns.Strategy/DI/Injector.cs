using Microsoft.Extensions.DependencyInjection;
using RealWorldDesignPatterns.Strategy.Contract;
using RealWorldDesignPatterns.Strategy.Factory;
using RealWorldDesignPatterns.Strategy.Strategies;

namespace RealWorldDesignPatterns.Strategy.DI
{
    public static class Injector
    {
        public static IServiceCollection AddShippingService(this IServiceCollection services)
        {
            services.AddHttpClient<FedexShippingStrategy>();
            services.AddHttpClient<DhlShippingStrategy>();
            services.AddHttpClient<UpsShippingStrategy>();
            
            services.AddScoped<IShippingStrategyFactory, ShippingStrategyFactory>();
            
            services.AddScoped<IShippingService, FedexShippingStrategy>();
            services.AddScoped<IShippingService, DhlShippingStrategy>();
            services.AddScoped<IShippingService, UpsShippingStrategy>();

            return services;
        }
    }
}