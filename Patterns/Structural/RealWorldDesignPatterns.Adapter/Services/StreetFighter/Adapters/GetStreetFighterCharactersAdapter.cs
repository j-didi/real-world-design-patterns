using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Extensions;

namespace RealWorldDesignPatterns.Adapter.Services.StreetFighter.Adapters
{
    public class GetStreetFighterCharactersAdapter : IGetStreetFighterCharactersAdapter
    {
        public List<GetCharactersResult> Map(IEnumerable<string> items) =>
            items.Select(line =>
            {
                var parts = line.Split(';');
                return new GetCharactersResult
                {
                    Universe = "Street Fighter",
                    Name = parts[0],
                    Gender = parts[1].AdaptGender(),
                    HomeWorld = parts[2]
                };
            }).ToList();
    }
}