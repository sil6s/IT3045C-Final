using IT3045C_Final.Data;
using IT3045C_Final.Seeds;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure the database context with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services for controllers, API documentation, and OpenAPI support
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "IT3045C Final Project API";
    config.Version = "v1";
});

var app = builder.Build();

// Middleware for development environment: Enable Swagger UI and OpenAPI documentation
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi3();
}

// Seed data on application startup
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    DataSeeder.Seed(context);
}

// Configure HTTPS redirection and authorization
// app.UseHttpsRedirection();
// app.UseAuthorization();

// Map controllers to routes
app.MapControllers();

// Run the application
app.Run();
