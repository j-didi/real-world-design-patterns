using System.Collections.Generic;
using RealWorldDesignPatterns.Adapter.Contract;

namespace RealWorldDesignPatterns.Adapter.Services.StreetFighter.Adapters
{
    public interface IGetStreetFighterCharactersAdapter
    {
        public List<GetCharactersResult> Map(IEnumerable<string> items);
    }
}
