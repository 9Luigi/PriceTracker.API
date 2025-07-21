using MediatR;
using Microsoft.EntityFrameworkCore;
using PriceTracker.API.Domain.Exceptions;
using PriceTracker.API.Domain.Products;
using PriceTracker.API.Infrastructure.Persistence;

namespace PriceTracker.API.Application.Features.Queries.GetProductById;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{
	private readonly AppDbContext _context;
	private readonly ILogger<GetProductByIdHandler> _logger;

	public GetProductByIdHandler(
		AppDbContext context,
		ILogger<GetProductByIdHandler> logger)
	{
		_context = context;
		_logger = logger;
	}

	public async Task<Product> Handle(
		GetProductByIdQuery request,
		CancellationToken cancellationToken)
	{
		try
		{
			var product = await _context.Products
				.AsNoTracking() // recommended for read-only queries
				.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

			if (product is null)
			{
				_logger.LogWarning("Product with ID {ProductId} not found", request.Id);
				throw new NotFoundException($"Product with ID {request.Id} not found");
			}

			return product;
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error while fetching product with ID {ProductId}", request.Id);
			throw; // Handler should not swallow exceptions
		}
	}
}
