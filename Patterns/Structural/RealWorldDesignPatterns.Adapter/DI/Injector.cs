using Microsoft.Extensions.DependencyInjection;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Services.RickAndMorty;
using RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Adapters;
using RealWorldDesignPatterns.Adapter.Services.StarWars;
using RealWorldDesignPatterns.Adapter.Services.StarWars.Adapters;
using RealWorldDesignPatterns.Adapter.Services.StreetFighter;
using RealWorldDesignPatterns.Adapter.Services.StreetFighter.Adapters;

namespace RealWorldDesignPatterns.Adapter.DI
{
    public static class Injector
    {
        public static IServiceCollection AddCharactersService(this IServiceCollection services)
        {
            services.AddHttpClient<GetRickAndMortyCharactersService>();
            services.AddScoped<IGetCharactersService, GetRickAndMortyCharactersService>();
            services.AddScoped<IGetRickAndMortyCharactersAdapter, GetRickAndMortyCharactersAdapter>();
            
            services.AddScoped<IGetCharactersService, GetStarWarsCharactersService>();
            services.AddScoped<IGetStarWarsCharactersAdapter, GetStarWarsCharactersAdapter>();
            
            services.AddScoped<IGetCharactersService, GetStreetFighterCharactersService>();
            services.AddScoped<IGetStreetFighterCharactersAdapter, GetStreetFighterCharactersAdapter>();

            return services;
        }
    }
}