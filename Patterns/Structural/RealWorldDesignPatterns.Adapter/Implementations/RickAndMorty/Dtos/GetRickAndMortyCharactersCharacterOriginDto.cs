using System.Text.Json.Serialization;

namespace RealWorldDesignPatterns.Adapter.Implementations.RickAndMorty.Dtos
{
    public class GetRickAndMortyCharactersCharacterOriginDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}