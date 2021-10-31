using System.Collections.Generic;

namespace RealWorldDesignPatterns.Adapter.Services.StarWars.Dtos
{
    public class GetStarWarsCharactersAllPeopleDto
    {
        public IList<GetStarWarsCharactersCharacterDto> People { get; set; }
    }
}