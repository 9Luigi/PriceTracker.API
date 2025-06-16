using System;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

/*builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseMySql(
		builder.Configuration.GetConnectionString("DefaultConnection"),
		new MySqlServerVersion(new Version(9, 0, 0))));*/

app.UseHttpsRedirection();
app.MapControllers();
app.Run();