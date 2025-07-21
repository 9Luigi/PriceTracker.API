using MediatR;
using Microsoft.AspNetCore.Mvc;
using PriceTracker.API.Domain.Features.Queries.GetProductById;
using PriceTracker.API.Domain.Products;
using PriceTrackerAPI.Features.Products.Queries.GetProductById;

namespace PriceTracker.API.API.Controllers;

[ApiController]
[Route("api/product")]
public class ProductsController : ControllerBase
{
	private readonly IMediator _mediator;

	public ProductsController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Product>> GetProduct(int id)
	{
		var query = new GetProductByIdQuery(id);
		var product = await _mediator.Send(query);

		return product == null ? NotFound() : Ok(product);
	}
}