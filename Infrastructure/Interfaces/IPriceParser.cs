namespace PriceTracker.API.Infrastructure.Interfaces
{
	public interface IPriceParser
	{
		Task<ParseResult> ParseAsync(string url);
	}
	public record ParseResult(string Name, decimal Price);
}
