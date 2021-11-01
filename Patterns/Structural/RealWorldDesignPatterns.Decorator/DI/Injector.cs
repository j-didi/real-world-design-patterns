using System.Net.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using RealWorldDesignPatterns.Decorator.Contract;
using RealWorldDesignPatterns.Decorator.Implementations;

namespace RealWorldDesignPatterns.Decorator.DI
{
    public static class Injector
    {
        public static IServiceCollection AddAddressByZipCodeService(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddHttpClient<IAddressByZipCodeService>();
            
            services.AddScoped<IAddressByZipCodeService>(serviceProvider => 
                new AddressByZipCodeService(serviceProvider.GetService<HttpClient>()));
            
            services.Decorate<IAddressByZipCodeService>((inner, provider) => 
                new AddressByZipCodeCacheDecorator(inner, provider.GetService<IMemoryCache>()));
            
            services.Decorate<IAddressByZipCodeService>((inner, _) => 
                new AddressByZipCodeLoggerDecorator(inner));

            return services;
        }
    }
}