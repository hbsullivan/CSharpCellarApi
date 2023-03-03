namespace CellarApi.Models
{
  public class Region 
  {
    public int RegionId { get; set; }
    public string Appellation { get; set; }
    public string Country { get; set; }
    public string Climate { get; set; }
    public string Soil { get; set; }
  }
}