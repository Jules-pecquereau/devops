using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var dbProvider = builder.Configuration["DbProvider"] ?? "mysql";
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    if (dbProvider.ToLower() == "postgres")
    {
        options.UseNpgsql(connectionString);
    }

    else
    {
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", async (ApplicationDbContext db) =>
{
    var forecasts = await db.Forecasts
        .Select(f => new { f.Id, villllllllllllllllllle = f.City, Température = f.Temperature })
        .ToListAsync()
    ;

    return Results.Ok(forecasts);
})
.WithName("GetWeatherForecast");

app.Run();
