using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CellarApi.Models;

namespace CellarApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RegionsController : ControllerBase
  {
    private readonly CellarApiContext _db;

    public RegionsController(CellarApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Region>>> Get(string appellation, string country, string climate, string soil)
    {
      IQueryable<Region> query = _db.Regions.AsQueryable();

      if (appellation != null)
      {
        query = query.Where(entry => entry.Appellation == appellation);
      }
      
      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if (climate != null)
      {
        query = query.Where(entry => entry.Climate == climate);
      }

      if (soil != null)
      {
        query = query.Where(entry => entry.Soil == soil);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Region>> GetAnimal(int id)
    {
      Region region = await _db.Regions.FindAsync(id);

      if (region == null)
      {
        return NotFound();
      }

      return region;
    }
  }
}