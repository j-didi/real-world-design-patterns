using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using RealWorldDesignPatterns.Adapter.Contract;
using RealWorldDesignPatterns.Adapter.Services.StreetFighter.Adapters;

namespace RealWorldDesignPatterns.Adapter.Services.StreetFighter
{
    public class GetStreetFighterCharactersService: IGetCharactersService
    {
        private readonly IGetStreetFighterCharactersAdapter _adapter;

        private static string Path =>
            "../../Patterns/Structural/RealWorldDesignPatterns.Adapter/Services/StreetFighter/File/Characters.txt";

        public GetStreetFighterCharactersService(IGetStreetFighterCharactersAdapter adapter)
        {
            _adapter = adapter;
        }
        
        public async Task<List<GetCharactersResult>> GetAsync()
        {
            var items = await File.ReadAllLinesAsync(Path);
            return _adapter.Map(items);
        }
    }
}