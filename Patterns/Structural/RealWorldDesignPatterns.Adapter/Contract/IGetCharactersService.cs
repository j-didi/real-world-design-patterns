using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealWorldDesignPatterns.Adapter.Contract
{
    public interface IGetCharactersService
    {
        Task<List<GetCharactersResult>> GetAsync();
    }
}