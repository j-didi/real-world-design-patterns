using System.Collections.Generic;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Dtos;

namespace RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Adapters
{
    public interface IGetRickAndMortyCharactersAdapter
    {
        public List<GetCharactersResult> Map(GetRickAndMortyCharactersDto charactersDto);
    }
}
