using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using RealWorldDesignPatterns.Adapter.Contract;

namespace RealWorldDesignPatterns.Adapter.Implementations.StreetFighter
{
    public class GetStreetFighterCharactersService: IGetCharactersService
    {
        private static string Path =>
            "../../Patterns/Structural/RealWorldDesignPatterns.Adapter/Services/StreetFighter/File/Characters.txt";

        public async Task<List<GetCharactersResult>> GetAsync()
        {
            var items = await File.ReadAllLinesAsync(Path);
            return GetStreetFighterCharactersAdapter.Map(items);
        }
    }
}