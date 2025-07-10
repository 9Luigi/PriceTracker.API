using MediatR;
using PriceTracker.API.Domain.Products;

namespace PriceTracker.API.Domain.Features.Queries.GetProductById
{
	public record class GetProductByIdQuery(int Id) : IRequest<Product>;
}
