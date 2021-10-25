using System.Threading.Tasks;

namespace RealWorldDesignPatterns.Decorator.Contract
{
    public interface IAddressByZipCodeService
    {
        Task<AddressByZipCodeResult> GetAsync(AddressByZipCodeQuery query);
    }
}