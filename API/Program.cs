using Core.Entities;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

try
{
	// Add services to the container.

	builder.Services.AddControllers();
	// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
	builder.Services.AddOpenApi();

	builder.Services.AddDbContext<ISPDBContext>(options =>
	{
		options.UseSqlServer(builder.Configuration.GetConnectionString("ISPDbString"));
	});

	var app = builder.Build();

	// Configure the HTTP request pipeline.
	if (app.Environment.IsDevelopment())
	{
		app.MapOpenApi();
		app.MapScalarApiReference();
	}

	app.UseHttpsRedirection();

	app.UseAuthorization();

	app.MapControllers();

	// Get all customers
	app.MapGet("/api/Customers", async (ISPDBContext dbContext) =>
		await dbContext.Customers.ToListAsync());

	// Get a customer by ID
	app.MapGet("/api/Customers/{id:int}", async (int id, ISPDBContext dbContext) =>
		await dbContext.Customers.FindAsync(id) is Customer customer ? Results.Ok(customer) : Results.NotFound());

	app.Run();
}
catch (Exception ex)
{
	Console.WriteLine($"ISP APIs failed to start: {ex.Message}");
	Console.WriteLine($"Stack Trace: {ex.StackTrace}");
	throw; // re-throw so the process still exits with a non-zero code
}
