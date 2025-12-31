namespace AdsumPater.Core.Entities
{
    public class Mision
    {
        public int Id { get; set; }
        public int Anio { get; set; }

        public int PuebloId { get; set; }
        public Pueblo ? Pueblo { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public ICollection<Testimonio> Testimonios { get; set; } = new List<Testimonio>();
        public ICollection<FotoMision> Fotos { get; set; } = new List<FotoMision>();
    }
}
