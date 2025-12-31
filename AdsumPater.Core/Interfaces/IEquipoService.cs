using AdsumPater.Core.Entities;

namespace AdsumPater.Core.Interfaces;

public interface IEquipoService
{
    Task<List<TeamMember>> ObtenerEquipoAsync();
}
