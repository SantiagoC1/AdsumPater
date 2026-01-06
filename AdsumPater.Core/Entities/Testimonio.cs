using System;

namespace AdsumPater.Core.Entities;

public class Testimonio
{
    public int Id {get;set;}
    public string Autor {get;set;} = string.Empty;
    public string Texto {get;set;} = string.Empty;
    public DateTime Fecha {get;set;} = DateTime.UtcNow;
}
