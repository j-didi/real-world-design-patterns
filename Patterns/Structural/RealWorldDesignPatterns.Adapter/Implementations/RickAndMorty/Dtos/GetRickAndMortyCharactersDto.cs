using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RealWorldDesignPatterns.Adapter.Implementations.RickAndMorty.Dtos
{
    public class GetRickAndMortyCharactersDto
    {
        [JsonPropertyName("results")]
        public List<GetRickyAndMortyCharactersCharacterDto> Characters { get; set; }
    }
}