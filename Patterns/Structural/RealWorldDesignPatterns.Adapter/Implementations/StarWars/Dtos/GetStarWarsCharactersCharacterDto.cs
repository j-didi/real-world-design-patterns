namespace RealWorldDesignPatterns.Adapter.Implementations.StarWars.Dtos
{
    public class GetStarWarsCharactersCharacterDto
    {
        public string Name { get; set; }
        
        public string Gender { get; set; }
        
        public GetStarWarsCharactersCharacterOriginDto HomeWorld { get; set; }
    }
}