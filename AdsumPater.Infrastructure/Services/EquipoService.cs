using AdsumPater.Core.Entities;
using AdsumPater.Core.Enums;
using AdsumPater.Core.Interfaces;

namespace AdsumPater.Infrastructure.Services;

public class EquipoService : IEquipoService
{
    public Task<List<TeamMember>> ObtenerEquipoAsync()
    {
        var equipo = new List<TeamMember>
        {
            // Rectores (4)
            new() { Nombre="Juan", Apellido="Pérez", Apodo="Juampi", Edad=23, CarreraOProfesion="Ingeniería", Rol=RolEquipo.Rector },
            new() { Nombre="María", Apellido="Gómez", Apodo="Mery", Edad=22, CarreraOProfesion="Medicina", Rol=RolEquipo.Rector },
            new() { Nombre="Lucas", Apellido="Fernández", Apodo="Lu", Edad=24, CarreraOProfesion="Derecho", Rol=RolEquipo.Rector },
            new() { Nombre="Ana", Apellido="López", Apodo="Ani", Edad=21, CarreraOProfesion="Psicología", Rol=RolEquipo.Rector },

            // Peña y Comunicación (2)
            new() { Nombre="Tomás", Apellido="Ruiz", Apodo="Tomy", Edad=22, CarreraOProfesion="Comunicación", Rol=RolEquipo.PenaYComunicacion },
            new() { Nombre="Sofi", Apellido="Martínez", Apodo="Sofi", Edad=21, CarreraOProfesion="Diseño", Rol=RolEquipo.PenaYComunicacion },

            // Infraestructura (2)
            new() { Nombre="Nico", Apellido="Díaz", Apodo="Nico", Edad=25, CarreraOProfesion="Arquitectura", Rol=RolEquipo.Infraestructura },
            new() { Nombre="Fede", Apellido="Suárez", Apodo="Fede", Edad=24, CarreraOProfesion="Ingeniería", Rol=RolEquipo.Infraestructura },

            // Via Crucis (2)
            new() { Nombre="Lauti", Apellido="Molina", Apodo="Lau", Edad=23, CarreraOProfesion="Historia", Rol=RolEquipo.ViaCrucis },
            new() { Nombre="Cami", Apellido="Rojas", Apodo="Cami", Edad=22, CarreraOProfesion="Educación", Rol=RolEquipo.ViaCrucis },

            // Espiritualidad (2)
            new() { Nombre="Pablo", Apellido="Ortiz", Apodo="Pablito", Edad=26, CarreraOProfesion="Teología", Rol=RolEquipo.Espiritualidad },
            new() { Nombre="Lucía", Apellido="Benítez", Apodo="Lu", Edad=24, CarreraOProfesion="Filosofía", Rol=RolEquipo.Espiritualidad },

            // Coro (2)
            new() { Nombre="Agus", Apellido="Silva", Apodo="Agus", Edad=21, CarreraOProfesion="Música", Rol=RolEquipo.Coro },
            new() { Nombre="Vale", Apellido="Castro", Apodo="Vale", Edad=22, CarreraOProfesion="Profesorado de Música", Rol=RolEquipo.Coro },

            // Apostolado (3)
            new() { Nombre="Nacho", Apellido="Herrera", Apodo="Nacho", Edad=23, CarreraOProfesion="Trabajo Social", Rol=RolEquipo.Apostolado },
            new() { Nombre="Belén", Apellido="Sosa", Apodo="Belu", Edad=22, CarreraOProfesion="Psicopedagogía", Rol=RolEquipo.Apostolado },
            new() { Nombre="Mateo", Apellido="Vega", Apodo="Mate", Edad=24, CarreraOProfesion="Economía", Rol=RolEquipo.Apostolado },

            //Asesores (2)
            new() { Nombre="Belén", Apellido="Sosa", Apodo="Belu", Edad=22, CarreraOProfesion="Psicopedagogía", Rol=RolEquipo.Asesora },
            new() { Nombre="Mateo", Apellido="Vega", Apodo="Mate", Edad=24, CarreraOProfesion="Economía", Rol=RolEquipo.Asesor }
        };

        return Task.FromResult(equipo);
    }
}
