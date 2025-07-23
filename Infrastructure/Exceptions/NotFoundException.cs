namespace PriceTracker.API.Domain.Exceptions;
public class NotFoundException : Exception //TODO refuse exception for not found entities, use Result<T> instead maybe?
{
	public NotFoundException() { }
	public NotFoundException(string message) : base(message) { }
	public NotFoundException(string message, Exception inner)
		: base(message, inner) { }
}
