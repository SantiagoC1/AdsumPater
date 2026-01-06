using AdsumPater.Core.Entities;
using AdsumPater.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace AdsumPater.Infrastructure.Data;

public class AdsumPaterDbContext : DbContext
{
    public AdsumPaterDbContext(DbContextOptions<AdsumPaterDbContext> options) : base(options) { }

    public DbSet<Intencion> Intenciones => Set<Intencion>();
    public DbSet<Reflexion> Reflexiones => Set<Reflexion>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Intencion>(e =>
        {
            e.ToTable("Intenciones");
            e.HasKey(x => x.Id);
            e.Property(x => x.Texto).IsRequired().HasMaxLength(1000);
            e.Property(x => x.Nombre).HasMaxLength(120);
            e.Property(x => x.Fecha).IsRequired();
            e.Property(x => x.Rezos).IsRequired();
            e.Property(x => x.Estado).IsRequired();

            e.HasIndex(x => x.Fecha);
            e.HasIndex(x => x.Estado);
        });

        modelBuilder.Entity<Reflexion>(e =>
        {
            e.ToTable("Reflexiones");
            e.HasKey(x => x.Id);
            e.Property(x => x.Titulo).IsRequired().HasMaxLength(200);
            e.Property(x => x.Contenido).IsRequired().HasMaxLength(4000);
            e.Property(x => x.Autor).HasMaxLength(120);
            e.Property(x => x.Fecha).IsRequired();
            e.Property(x => x.Estado).IsRequired();

            e.HasIndex(x => x.Fecha);
            e.HasIndex(x => x.Estado);
        });

        // Seed opcional (podés borrar si no querés)
        modelBuilder.Entity<Reflexion>().HasData(
            new Reflexion
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Titulo = "Semana Santa: volver al corazón",
                Contenido = "Tomate un rato para silencio. Una oración breve y sincera abre camino.",
                Autor = "Equipo Adsum Pater",
                Fecha = DateTime.UtcNow.AddDays(-2),
                Estado = EstadoPublicacion.Aprobada
            }
        );
    }
}
