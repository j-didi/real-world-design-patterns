using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Implementations.RickAndMorty.Dtos;

namespace RealWorldDesignPatterns.Adapter.Implementations.RickAndMorty
{
    public class GetRickAndMortyCharactersService: IGetCharactersService
    {
        private readonly HttpClient _client;

        public GetRickAndMortyCharactersService(HttpClient client)
        {
            _client = client;
        }
        
        public async Task<List<GetCharactersResult>> GetAsync()
        {
            const string uri = "https://rickandmortyapi.com/api/character";
            var httpResult = await _client.GetAsync(uri);
            var result = await httpResult.Content
                .ReadFromJsonAsync<GetRickAndMortyCharactersDto>();
            
            return GetRickAndMortyCharactersAdapter.Map(result);
        }
    }
}