using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Services.StarWars.Adapters;
using RealWorldDesignPatterns.Adapter.Services.StarWars.Dtos;

namespace RealWorldDesignPatterns.Adapter.Services.StarWars
{
    public class GetStarWarsCharactersService: IGetCharactersService
    {
        private readonly GraphQLHttpClient  _client;
        private readonly IGetStarWarsCharactersAdapter _adapter;

        private static string Query 
            => @"query { allPeople(first: 5) { people { name, gender, homeworld { name } } } }";
 
        public GetStarWarsCharactersService(
            IGetStarWarsCharactersAdapter adapter
        )
        {
            _client = CreateClient();
            _adapter = adapter;
        }

        private static GraphQLHttpClient CreateClient()
        {
            const string endpoint = "https://swapi-graphql.netlify.app/.netlify/functions/index";    
  
            var httpClientOption = new GraphQLHttpClientOptions    
            {    
                EndPoint = new Uri(endpoint)
            };
            
            return new GraphQLHttpClient(httpClientOption, new NewtonsoftJsonSerializer());
        }
        
        public async Task<List<GetCharactersResult>> GetAsync()
        {
            var request = new GraphQLRequest(Query);
            var response = await _client.SendQueryAsync<GetStarWarsCharactersResultDto>(request);
            return _adapter.Map(response.Data);
        }
    }
}