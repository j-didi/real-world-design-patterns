using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Adapters;
using RealWorldDesignPatterns.Adapter.Services.RickAndMorty.Dtos;

namespace RealWorldDesignPatterns.Adapter.Services.RickAndMorty
{
    public class GetRickAndMortyCharactersService: IGetCharactersService
    {
        private readonly HttpClient _client;
        private readonly IGetRickAndMortyCharactersAdapter _adapter;

        public GetRickAndMortyCharactersService(
            IGetRickAndMortyCharactersAdapter adapter,
            HttpClient client
        )
        {
            _client = client;
            _adapter = adapter;
        }
        
        public async Task<List<GetCharactersResult>> GetAsync()
        {
            const string uri = "https://rickandmortyapi.com/api/character";
            var httpResult = await _client.GetAsync(uri);
            var result = await httpResult.Content.ReadFromJsonAsync<GetRickAndMortyCharactersDto>();
            return _adapter.Map(result);
        }
    }
}