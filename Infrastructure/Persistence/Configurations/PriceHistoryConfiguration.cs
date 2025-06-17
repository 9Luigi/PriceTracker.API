using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PriceTracker.API.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace PriceTracker.API.Infrastructure.Persistence.Configurations;
public class PriceHistoryConfiguration : BaseEntityConfiguration<PriceHistory>
{
	public override void Configure(EntityTypeBuilder<PriceHistory> builder)
	{
		base.Configure(builder);

		builder.Property(ph => ph.Price)
			  .HasColumnType("decimal(10,2)")
			  .IsRequired();
	}
}