using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using RealWorldDesignPatterns.Decorator.Contract;

namespace RealWorldDesignPatterns.Decorator.Implementations
{
    public class AddressByZipCodeCacheDecorator : IAddressByZipCodeService
    {
        private readonly IAddressByZipCodeService _service;
        private readonly IMemoryCache _cache;

        public AddressByZipCodeCacheDecorator(
            IAddressByZipCodeService service,
            IMemoryCache cache
        )
        {
            _service = service;
            _cache = cache;
        }

        public async Task<AddressByZipCodeResult> GetAsync(AddressByZipCodeQuery query)
        {
            var cacheKey = $"AddressByZipCode::{query.ZipCode}";
            if (_cache.TryGetValue<AddressByZipCodeResult>(cacheKey, out var cachedResult))
                return cachedResult;
            
            var result = await _service.GetAsync(query);
            _cache.Set(cacheKey, result, TimeSpan.FromDays(1));
            return result;
        }
    }
}