using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Implementations.StarWars.Dtos;

namespace RealWorldDesignPatterns.Adapter.Implementations.StarWars
{
    public class GetStarWarsCharactersService: IGetCharactersService
    {
        private readonly GraphQLHttpClient  _client;

        private static string Endpoint =>
            "https://swapi-graphql.netlify.app/.netlify/functions/index";
        private static string Query 
            => @"query { allPeople(first: 5) { people { name, gender, homeworld { name } } } }";
 
        public GetStarWarsCharactersService()
        {
            var httpClientOption = new GraphQLHttpClientOptions    
            {    
                EndPoint = new Uri(Endpoint)
            };
            
            _client = new GraphQLHttpClient(
                httpClientOption, 
                new NewtonsoftJsonSerializer());
        }
        
        public async Task<List<GetCharactersResult>> GetAsync()
        {
            var request = new GraphQLRequest(Query);
            var response = await _client.SendQueryAsync<GetStarWarsCharactersResultDto>(request);
            return GetStarWarsCharactersAdapter.Map(response.Data);
        }
    }
}