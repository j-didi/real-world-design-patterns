using System.Collections.Generic;

namespace RealWorldDesignPatterns.Adapter.Implementations.StarWars.Dtos
{
    public class GetStarWarsCharactersAllPeopleDto
    {
        public IList<GetStarWarsCharactersCharacterDto> People { get; set; }
    }
}