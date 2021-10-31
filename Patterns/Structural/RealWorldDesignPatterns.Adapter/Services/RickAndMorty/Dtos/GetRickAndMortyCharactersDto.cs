using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Dtos
{
    public class GetRickAndMortyCharactersDto
    {
        [JsonPropertyName("results")]
        public List<GetRickyAndMortyCharactersCharacterDto> Characters { get; set; }
    }
}