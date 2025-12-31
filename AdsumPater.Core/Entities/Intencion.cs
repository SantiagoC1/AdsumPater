

namespace AdsumPater.Core.Entities;

public class Intencion
{
    public int Id {get;set;}
    public string contenido {get;set;} = string.Empty;
    public DateTime Fecha {get;set;} = DateTime.UtcNow;

}
