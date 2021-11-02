using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.Adapter.Common;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Implementations.StarWars.Dtos;

namespace RealWorldDesignPatterns.Adapter.Implementations.StarWars
{
    public static class GetStarWarsCharactersAdapter
    {
        public static List<GetCharactersResult> Map(GetStarWarsCharactersResultDto dto) =>
            dto
                .AllPeople
                .People
                .Select(e => new GetCharactersResult
                {
                    Universe = "Star Wars",
                    Name = e.Name,
                    Gender = e.Gender.AdaptGender(),
                    HomeWorld = e.HomeWorld.Name.AdaptHomeWorld()
                }).ToList();
    }
}