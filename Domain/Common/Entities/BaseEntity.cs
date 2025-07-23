namespace PriceTracker.API.Domain.Common.Entities
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public DateTime ModifiedAt { get; set; }
	}
}
