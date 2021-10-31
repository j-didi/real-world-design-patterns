using System.Collections.Generic;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Dtos;
using RealWorldDesignPatterns.Adapter.Services.StarWars.Dtos;

namespace RealWorldDesignPatterns.Adapter.Services.StarWars.Adapters
{
    public interface IGetStarWarsCharactersAdapter
    {
        public List<GetCharactersResult> Map(GetStarWarsCharactersResultDto dto);
    }
}
