namespace AdsumPater.Core.Entities;

public class FotoMision
{
    public int Id {get;set;}
    public string Url {get;set;} = string.Empty;
    public string Descripcion {get;set;} =string.Empty;

    public int MisionId {get;set;}
    public Mision ? Mision {get;set;}
}
