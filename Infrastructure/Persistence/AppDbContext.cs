using Microsoft.EntityFrameworkCore;

namespace PriceTracker.API.Infrastructure.Persistence
{
	public class AppDbContext : DbContext 
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options) { }
	}
}
