using PriceTracker.API.Domain.Common.Entities;

namespace PriceTracker.API.Domain.Products;

public class Product : BaseEntity
{
	public string Name { get; set; } = string.Empty;
	public string Url { get; set; } = string.Empty; //TODO to value object ProductUrl
	public decimal? CurrentPrice { get; set; } //TODO to value object MONEY
	public List<PriceHistory> PriceHistories { get; set; } = new();
}