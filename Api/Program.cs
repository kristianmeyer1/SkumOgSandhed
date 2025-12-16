using SkumOgSandhed.Application.UseCases;
using SkumOgSandhed.Application.Interfaces;
using SkumOgSandhed.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// --- Services ---
// Tilføj CORS for at tillade Client på en anden port
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5216") // Client port
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Registrer DI for repository og use case
builder.Services.AddScoped<IBeerRepository, InMemoryBeerRepository>();
builder.Services.AddScoped<IGetBeers, GetBeers>();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// --- Middleware ---
app.UseCors(); // Brug CORS

// --- Minimal API Endpoint ---
app.MapGet("/api/beers", async (IGetBeers getBeers) =>
{
    try
    {
        var beers = await getBeers.ExecuteAsync();
        return Results.Ok(beers);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

// --- Run app ---
app.Run();
