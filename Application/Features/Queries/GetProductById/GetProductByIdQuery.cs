using MediatR;
using PriceTracker.API.Domain.Products;

namespace PriceTracker.API.Application.Features.Queries.GetProductById
{
	public record class GetProductByIdQuery(int Id) : IRequest<Product>;
}
