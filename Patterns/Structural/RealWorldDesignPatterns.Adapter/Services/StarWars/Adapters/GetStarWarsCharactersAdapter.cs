using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Extensions;
using RealWorldDesignPatterns.Adapter.Services.StarWars.Dtos;

namespace RealWorldDesignPatterns.Adapter.Services.StarWars.Adapters
{
    public class GetStarWarsCharactersAdapter : IGetStarWarsCharactersAdapter
    {
        public List<GetCharactersResult> Map(GetStarWarsCharactersResultDto dto) =>
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