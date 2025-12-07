using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PriceTracker.API.Models;

namespace PriceTracker.API.Infrastructure.Configurations;
public class ProductConfiguration : BaseEntityConfiguration<Product>
{
	public override void Configure(EntityTypeBuilder<Product> builder)
	{
		base.Configure(builder);

		builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
		builder.Property(p => p.Url).HasMaxLength(512).IsRequired();
		builder.HasIndex(p => p.Url).IsUnique();

		builder.HasMany(p => p.PriceHistories)
			   .WithOne(ph => ph.Product)
			   .HasForeignKey(ph => ph.ProductId);
	}
}