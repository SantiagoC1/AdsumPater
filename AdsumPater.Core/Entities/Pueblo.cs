namespace AdsumPater.Core.Entities
{
    public class Pueblo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public string FotoUrl { get; set; } = string.Empty;

        public ICollection<Mision> Misiones { get; set; } = new List<Mision>();
    }
}
