using AdsumPater.Core.Entities;
using AdsumPater.Core.Enums;
using AdsumPater.Core.Interfaces;
using AdsumPater.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AdsumPater.Infrastructure.Services;

public class ForoService : IForoService
{
    private readonly AdsumPaterDbContext _db;

    public ForoService(AdsumPaterDbContext db)
    {
        _db = db;
    }

    // --- MÉTODOS PÚBLICOS (Lectura y Creación de usuarios) ---

    public async Task<List<Intencion>> ObtenerIntencionesAprobadasAsync(string? search = null, CancellationToken ct = default)
    {
        IQueryable<Intencion> q = _db.Intenciones.AsNoTracking()
            .Where(x => x.Estado == EstadoPublicacion.Aprobada);

        if (!string.IsNullOrWhiteSpace(search))
        {
            var s = search.Trim().ToLower();
            q = q.Where(x =>
                (x.Nombre ?? "").ToLower().Contains(s) ||
                x.Texto.ToLower().Contains(s));
        }

        return await q.OrderByDescending(x => x.Fecha).ToListAsync(ct);
    }

    public async Task<List<Reflexion>> ObtenerReflexionesAprobadasAsync(CancellationToken ct = default)
    {
        return await _db.Reflexiones.AsNoTracking()
            .Where(x => x.Estado == EstadoPublicacion.Aprobada)
            .OrderByDescending(x => x.Fecha)
            .ToListAsync(ct);
    }

    public async Task<Intencion> CrearIntencionAsync(string? nombre, string texto, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(texto) || texto.Trim().Length < 6)
            throw new ArgumentException("La intención es muy corta.");

        var entity = new Intencion
        {
            Nombre = string.IsNullOrWhiteSpace(nombre) ? null : nombre.Trim(),
            Texto = texto.Trim(),
            Fecha = DateTime.UtcNow,
            Estado = EstadoPublicacion.Pendiente, // Nace pendiente de moderación
            Rezos = 0
        };

        _db.Intenciones.Add(entity);
        await _db.SaveChangesAsync(ct);

        return entity;
    }

    public async Task<bool> SumarRezoAsync(Guid intencionId, CancellationToken ct = default)
    {
        var it = await _db.Intenciones
            .FirstOrDefaultAsync(x => x.Id == intencionId && x.Estado == EstadoPublicacion.Aprobada, ct);
        
        if (it is null) return false;

        it.Rezos++;
        await _db.SaveChangesAsync(ct);
        return true;
    }

    // --- MÉTODOS DE ADMIN (Gestión de Intenciones) ---

    public async Task<List<Intencion>> GetPendientesAsync(CancellationToken ct = default)
    {
        return await _db.Intenciones.AsNoTracking()
            .Where(x => x.Estado == EstadoPublicacion.Pendiente)
            .OrderByDescending(x => x.Fecha)
            .ToListAsync(ct);
    }

    public async Task<bool> AprobarAsync(Guid intencionId, CancellationToken ct = default)
    {
        var it = await _db.Intenciones.FirstOrDefaultAsync(x => x.Id == intencionId, ct);
        if (it is null) return false;

        it.Estado = EstadoPublicacion.Aprobada;
        await _db.SaveChangesAsync(ct);
        return true;
    }

    public async Task<bool> RechazarAsync(Guid intencionId, CancellationToken ct = default)
    {
        var it = await _db.Intenciones.FirstOrDefaultAsync(x => x.Id == intencionId, ct);
        if (it is null) return false;

        _db.Intenciones.Remove(it);
        await _db.SaveChangesAsync(ct);
        return true;
    }

    // --- MÉTODOS DE ADMIN (Gestión de Reflexiones - NUEVOS) ---

    public async Task CrearReflexionAsync(string titulo, string contenido, string autor, CancellationToken ct = default)
    {
        var entity = new Reflexion
        {
            Titulo = titulo,
            Contenido = contenido,
            Autor = autor,
            Fecha = DateTime.UtcNow,
            Estado = EstadoPublicacion.Aprobada // Las del admin se aprueban directo
        };

        _db.Reflexiones.Add(entity);
        await _db.SaveChangesAsync(ct);
    }

    public async Task<bool> EliminarReflexionAsync(Guid id, CancellationToken ct = default)
    {
        var item = await _db.Reflexiones.FirstOrDefaultAsync(x => x.Id == id, ct);
        if (item is null) return false;

        _db.Reflexiones.Remove(item);
        await _db.SaveChangesAsync(ct);
        return true;
    }
}