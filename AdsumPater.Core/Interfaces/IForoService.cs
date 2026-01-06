using AdsumPater.Core.Entities;

namespace AdsumPater.Core.Interfaces;

public interface IForoService
{
    // --- Intenciones (Público) ---
    Task<List<Intencion>> ObtenerIntencionesAprobadasAsync(string? search = null, CancellationToken ct = default);
    Task<Intencion> CrearIntencionAsync(string? nombre, string texto, CancellationToken ct = default);
    Task<bool> SumarRezoAsync(Guid intencionId, CancellationToken ct = default); 

    // --- Reflexiones (Público) ---
    Task<List<Reflexion>> ObtenerReflexionesAprobadasAsync(CancellationToken ct = default);

    // --- Admin: Gestión de Intenciones ---
    Task<List<Intencion>> GetPendientesAsync(CancellationToken ct = default);
    Task<bool> AprobarAsync(Guid intencionId, CancellationToken ct = default);
    Task<bool> RechazarAsync(Guid intencionId, CancellationToken ct = default);

    // --- Admin: Gestión de Reflexiones (NUEVOS) ---
    Task CrearReflexionAsync(string titulo, string contenido, string autor, CancellationToken ct = default);
    Task<bool> EliminarReflexionAsync(Guid id, CancellationToken ct = default);
}