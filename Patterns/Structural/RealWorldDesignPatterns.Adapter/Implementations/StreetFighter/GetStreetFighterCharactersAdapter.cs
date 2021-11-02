using System.Collections.Generic;
using System.Linq;
using RealWorldDesignPatterns.Adapter.Common;
using RealWorldDesignPatterns.Adapter.Contract;

namespace RealWorldDesignPatterns.Adapter.Implementations.StreetFighter
{
    public static class GetStreetFighterCharactersAdapter
    {
        public static List<GetCharactersResult> Map(IEnumerable<string> items) =>
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