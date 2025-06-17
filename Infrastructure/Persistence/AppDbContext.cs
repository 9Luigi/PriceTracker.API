using Microsoft.EntityFrameworkCore;
using PriceTracker.API.Domain.Products;
using System.Threading;
using System.Threading.Tasks;

namespace PriceTracker.API.Infrastructure.Persistence
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<PriceHistory> PriceHistories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//TODO ApplyConfigurationsFromAssembly
		}

		public override async Task<int> SaveChangesAsync(
			CancellationToken cancellationToken = default)
		{
			UpdateTimestamps(); 
			return await base.SaveChangesAsync(cancellationToken);
		}

		private void UpdateTimestamps()
		{
			foreach (var entry in ChangeTracker.Entries<BaseEntity>())
			{
				if (entry.State == EntityState.Added)
				{
					entry.Entity.CreatedAt = DateTime.UtcNow;
				}
				else if (entry.State == EntityState.Modified)
				{
					entry.Entity.ModifiedAt = DateTime.UtcNow;
				}
			}
		}
	}
}