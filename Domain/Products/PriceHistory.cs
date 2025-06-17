namespace PriceTracker.API.Domain.Products;

public class PriceHistory : BaseEntity
{
	public decimal Price { get; set; }
	public int ProductId { get; set; }
	public Product? Product { get; set; }
}