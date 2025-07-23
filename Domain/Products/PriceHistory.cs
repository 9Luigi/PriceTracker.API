using PriceTracker.API.Domain.Common.Entities;

namespace PriceTracker.API.Domain.Products;

public class PriceHistory : BaseEntity
{
	public decimal Price { get; set; } //TODO to value object MONEY
	public int ProductId { get; set; } 
	public Product? Product { get; set; }
}