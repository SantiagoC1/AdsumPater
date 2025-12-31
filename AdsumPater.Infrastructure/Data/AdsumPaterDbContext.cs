using Microsoft.EntityFrameworkCore;
using AdsumPater.Core.Entities;
public class AdsumPaterDbContext : DbContext
{
    public AdsumPaterDbContext(DbContextOptions<AdsumPaterDbContext> options)
        : base(options)
    {
    }

    public DbSet<Testimonio> Testimonios { get; set; }
    public DbSet<Intencion> Intenciones { get; set; }
    public DbSet<Pueblo> Pueblos { get; set; }
    public DbSet<Mision> Misiones { get; set; }
    public DbSet<FotoMision> Fotos { get; set; }
}
