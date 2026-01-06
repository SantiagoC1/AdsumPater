using AdsumPater.Core.Enums;

namespace AdsumPater.Core.Entities;
public class Reflexion
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string Contenido { get; set; } = string.Empty;
    public DateTimeOffset Fecha { get; set; } = DateTimeOffset.Now;

    public EstadoPublicacion Estado { get; set; } = EstadoPublicacion.Aprobada;
}