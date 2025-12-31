using AdsumPater.Core.Entities;

namespace AdsumPater.Core.Interfaces
{
    public interface IMisionService
    {
        Task<IEnumerable<Mision>> GetMisionesAsync();
        Task<Mision?> GetMisionByIdAsync(int id);
        Task<Mision> CrearMisionAsync(Mision mision);
    }
}
