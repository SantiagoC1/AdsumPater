using AdsumPater.Core.Entities;

namespace AdsumPater.Core.Interfaces
{
    public interface IIntencionService
    {
        Task<IEnumerable<Intencion>> GetIntencionesAsync();
        Task<Intencion> CrearIntencionAsync(Intencion intencion);
    }
}
