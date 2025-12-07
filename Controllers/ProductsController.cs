using MediatR;
using Microsoft.AspNetCore.Mvc;
using PriceTracker.API.Models;

namespace PriceTracker.API.Controllers;

[ApiController]
[Route("api/product")]
public class ProductsController : ControllerBase
{
	

	public ProductsController()
	{
		
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Product>> GetProduct(int id)
	{
		throw(new NotImplementedException());
	}
}