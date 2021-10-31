using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Extensions;
using RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Dtos;

namespace RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Adapters
{
    public class GetRickAndMortyCharactersAdapter : IGetRickAndMortyCharactersAdapter
    {
        public List<GetCharactersResult> Map(GetRickAndMortyCharactersDto charactersDto) =>
            charactersDto.Characters
                .Take(5)
                .Select(e => new GetCharactersResult
                {
                    Universe = "Rick and Morty",
                    Name = e.Name,
                    Gender = e.Gender.AdaptGender(),
                    HomeWorld = e.CharacterOrigin.Name.AdaptHomeWorld()
                }).ToList();
    }
}