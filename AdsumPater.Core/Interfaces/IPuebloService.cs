using AdsumPater.Core.Entities;

namespace AdsumPater.Core.Interfaces
{
    public interface IPuebloService
    {
        Task<IEnumerable<Pueblo>> GetPueblosAsync();
        Task<Pueblo?> GetPuebloByIdAsync(int id);
    }
}
