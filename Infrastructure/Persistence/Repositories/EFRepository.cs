using PriceTracker.API.Application.Interfaces;
using PriceTracker.API.Domain.Common.Entities;

namespace PriceTracker.API.Infrastructure.Persistence.Repositories
{
	public class EFRepository<T> : IAsyncRepository<T> where T : BaseEntity
	{
		protected readonly AppDbContext _dbContext;
		public EFRepository(AppDbContext dbContext)
		{
			_dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
		}

		public Task<T> AddAsync(T entity)
		{
			_dbContext.AddAsync(entity);
			throw new NotImplementedException(); //TODO save changes on each method or where
		}

		public Task DeleteAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ExistsAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task<IReadOnlyList<T>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<T?> GetByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
