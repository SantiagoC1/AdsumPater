using System;

namespace AdsumPater.Core.Entities;

public class Testimonio
{
    public int Id {get;set;}
    public string NombreAutor {get;set;} = string.Empty;
    public string Contenido {get;set;} = string.Empty;
    public DateTime Fecha {get;set;} = DateTime.UtcNow;
    public int MisionId {get;set;}
    public Mision ? Mision {get;set;}
}
