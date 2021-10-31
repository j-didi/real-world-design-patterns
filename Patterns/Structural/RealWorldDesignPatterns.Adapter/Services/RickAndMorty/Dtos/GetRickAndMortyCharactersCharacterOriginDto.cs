using System.Text.Json.Serialization;

namespace RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Dtos
{
    public class GetRickAndMortyCharactersCharacterOriginDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}