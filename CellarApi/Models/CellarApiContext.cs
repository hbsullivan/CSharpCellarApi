using Microsoft.EntityFrameworkCore;

namespace CellarApi.Models
{
  public class CellarApiContext : DbContext
  {
    public DbSet<Region> Regions { get; set; }

    public CellarApiContext(DbContextOptions<CellarApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Region>()
        .HasData(
          new Region { RegionId = 1, Appellation = "Dundee Hills AVA", Country = "USA", Climate = "Cool", Soil = "Jory"}
        );
    }
  }
}