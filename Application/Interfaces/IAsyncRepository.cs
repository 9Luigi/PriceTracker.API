using PriceTracker.API.Domain.Products;

namespace PriceTracker.API.Application.Interfaces
{
	public interface IAsyncRepository<T> where T : BaseEntity
	{
		Task<T?> GetByIdAsync(Guid id);
		Task<IReadOnlyList<T>> GetAllAsync();
		Task<T> AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
		Task<bool> ExistsAsync(Guid id);
	}
}
