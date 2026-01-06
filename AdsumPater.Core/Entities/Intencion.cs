

using AdsumPater.Core.Enums;

namespace AdsumPater.Core.Entities;

public class Intencion
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Nombre { get; set; }         // opcional
    public string Texto { get; set; } = string.Empty;
    public DateTimeOffset Fecha { get; set; } = DateTimeOffset.Now;

    public int Rezos { get; set; } = 0;
    public EstadoPublicacion Estado { get; set; } = EstadoPublicacion.Pendiente;
}
