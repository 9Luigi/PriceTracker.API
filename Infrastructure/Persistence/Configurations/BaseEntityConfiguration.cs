using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PriceTracker.API.Domain.Common.Entities;

namespace PriceTracker.API.Infrastructure.Persistence.Configurations;

public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T>
	where T : BaseEntity
{
	public virtual void Configure(EntityTypeBuilder<T> builder)
	{
		builder.HasKey(x => x.Id);
		builder.Property(x => x.CreatedAt)
			  .IsRequired()
			  .HasDefaultValueSql("CURRENT_TIMESTAMP");
		builder.Property(x => x.ModifiedAt);
	}
}