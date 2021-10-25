using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using RealWorldDesignPatterns.Decorator.Contract;

namespace RealWorldDesignPatterns.Decorator.Service
{
    public class AddressByZipCodeService : IAddressByZipCodeService
    {
        private readonly HttpClient _httpClient;

        public AddressByZipCodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AddressByZipCodeResult> GetAsync(AddressByZipCodeQuery query)
        {
            var uri = $"https://viacep.com.br/ws/{query.ZipCode}/json/";
            var httpResult = await _httpClient.GetAsync(uri);
            return await httpResult.Content.ReadFromJsonAsync<AddressByZipCodeResult>();
        }
    }
}