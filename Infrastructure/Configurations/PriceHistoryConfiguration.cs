using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PriceTracker.API.Models;

namespace PriceTracker.API.Infrastructure.Configurations;
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