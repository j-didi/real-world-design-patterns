using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.Adapter.Common;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Implementations.RickAndMorty.Dtos;

namespace RealWorldDesignPatterns.Adapter.Implementations.RickAndMorty
{
    public class GetRickAndMortyCharactersAdapter
    {
        public static List<GetCharactersResult> Map(GetRickAndMortyCharactersDto dto) =>
            dto.Characters
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