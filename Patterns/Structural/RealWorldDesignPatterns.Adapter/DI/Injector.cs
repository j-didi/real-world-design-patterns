using Microsoft.Extensions.DependencyInjection;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Implementations.RickAndMorty;
using RealWorldDesignPatterns.Adapter.Implementations.StarWars;
using RealWorldDesignPatterns.Adapter.Implementations.StreetFighter;

namespace RealWorldDesignPatterns.Adapter.DI
{
    public static class Injector
    {
        public static IServiceCollection AddCharactersService(this IServiceCollection services)
        {
            services.AddHttpClient<GetRickAndMortyCharactersService>();
            services.AddScoped<IGetCharactersService, GetRickAndMortyCharactersService>();
            services.AddScoped<IGetCharactersService, GetStarWarsCharactersService>();
            services.AddScoped<IGetCharactersService, GetStreetFighterCharactersService>();

            return services;
        }
    }
}