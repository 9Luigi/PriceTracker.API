using Microsoft.AspNetCore.Mvc;
using PriceTracker.API.Domain.Products;
using PriceTracker.API.Infrastructure.Persistence;

namespace PriceTracker.API.Controllers
{
	[ApiController]
	[Route("api/test")]
	public class TestController : ControllerBase
	{
		private readonly AppDbContext _context;

		public TestController(AppDbContext context)
		{
			_context = context;
		}

		[HttpPost]
		public async Task<IActionResult> Test()
		{
			var product = new Product
			{
				Name = "Test Product",
				Url = "http://test.com",
				CurrentPrice = 100.50m
			};

			_context.Products.Add(product);
			await _context.SaveChangesAsync();

			return Ok(new
			{
				product.Id,
				product.CreatedAt,
				product.ModifiedAt
			});
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> TestUpdate(int id)
		{
			var product = await _context.Products.FindAsync(id);
			product.CurrentPrice = 90.99m;

			await _context.SaveChangesAsync();

			return Ok(new
			{
				product.Id,
				OriginalCreatedAt = product.CreatedAt,
				product.ModifiedAt 
			});
		}
	}
}
