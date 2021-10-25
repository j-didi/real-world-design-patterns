using System.Text.Json.Serialization;

namespace RealWorldDesignPatterns.Decorator.Contract
{
    public record AddressByZipCodeResult
    {
        [JsonPropertyName("cep")]
        public string ZipCode { get; set; }
        
        [JsonPropertyName("uf")]
        public string State { get; set; }
        
        [JsonPropertyName("localidade")]
        public string City { get; set; }
        
        [JsonPropertyName("bairro")]
        public string District { get; set; }
        
        [JsonPropertyName("logradouro")]
        public string Street { get; set; }
    }
}