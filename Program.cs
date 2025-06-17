using Microsoft.EntityFrameworkCore;
using PriceTracker.API.Infrastructure.Persistence;
using System.Configuration;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
	if (connectionString is null)
		throw new InvalidOperationException("Connection string is not configured.");

	options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

});
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();