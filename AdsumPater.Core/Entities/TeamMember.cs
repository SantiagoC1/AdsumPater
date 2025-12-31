using AdsumPater.Core.Enums;

namespace AdsumPater.Core.Entities;

public class TeamMember
{
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public string Apodo { get; set; } = "";
    public int Edad { get; set; }
    public string CarreraOProfesion { get; set; } = "";

    // Para agrupar por rol/área
    public RolEquipo Rol { get; set; } // Ej: "Rectores", "Peña y Comunicación", etc.

    // Opcional: para fotos más adelante
    public string? FotoUrl { get; set; } // "img/equipo/fulano.jpg"
}
