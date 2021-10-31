using System.Text.Json.Serialization;

namespace RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Dtos
{
    public class GetRickyAndMortyCharactersCharacterDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        
        [JsonPropertyName("origin")]
        public GetRickAndMortyCharactersCharacterOriginDto CharacterOrigin { get; set; }
    }
}