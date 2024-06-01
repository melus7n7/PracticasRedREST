using backendnet.Data.Seed;
using backendnet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<CustomIdentityUser> (options)
{
    public DbSet<Pelicula> Pelicula { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<Bitacora> Bitacora { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SeedCategoria());
        modelBuilder.ApplyConfiguration(new SeedPelicula());
        modelBuilder.SeedUserIdentityData();

        base.OnModelCreating(modelBuilder);
    }
}