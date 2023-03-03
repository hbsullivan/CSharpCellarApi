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
          new Region { RegionId = 1, Appellation = "Dundee Hills AVA", Country = "USA", Climate = "Cool", Soil = "Jory"},

          new Region { RegionId = 2, Appellation = "Champage AOC", Country = "France", Climate = "Cool", Soil = "Chalk"},

          new Region { RegionId = 3, Appellation = "Chablis AOC", Country = "France", Climate = "Cool", Soil = "Limestone"},

          new Region { RegionId = 4, Appellation = "Rioja DOCa", Country = "Spain", Climate = "Warm", Soil = "Alluvial"},
          
          new Region { RegionId = 5, Appellation = "Chianti DOCG", Country = "Italy", Climate = "Warm", Soil = "Galestro"},

          new Region { RegionId = 6, Appellation = "Barossa Valley", Country = "Australia", Climate = "Warm", Soil = "Sandy Clay"},

          new Region { RegionId = 7, Appellation = "Marlborough", Country = "New Zealand", Climate = "Cool", Soil = "Alluvial"},

          new Region { RegionId = 8, Appellation = "Barolo DOCG", Country = "Italy", Climate = "Cool", Soil = "Clay"},

          new Region { RegionId = 9, Appellation = "Bourgogne AOC", Country = "France", Climate = "Cool", Soil = "Clay"},

          new Region { RegionId = 10, Appellation = "Muscadet AOC", Country = "France", Climate = "Cool", Soil = "Gneiss"}
        );
    }
  }
}