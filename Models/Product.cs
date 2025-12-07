namespace PriceTracker.API.Models;

public class Product : BaseEntity
{
	public string Name { get; set; } = string.Empty;
	public string Url { get; set; } = string.Empty; 
	public decimal? CurrentPrice { get; set; }
	public List<PriceHistory> PriceHistories { get; set; } = new();
}