using MediatR;
using Microsoft.EntityFrameworkCore;
using PriceTracker.API.Domain.Features.Queries.GetProductById;
using PriceTracker.API.Domain.Products;
using PriceTracker.API.Infrastructure.Persistence;

namespace PriceTrackerAPI.Features.Products.Queries.GetProductById;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{
	private readonly AppDbContext _context;

	public GetProductByIdHandler(AppDbContext context)
	{
		_context = context;
	}

	public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
	{
		return await _context.Products.FirstOrDefaultAsync(p => p.Id == request.Id);
	}
}
