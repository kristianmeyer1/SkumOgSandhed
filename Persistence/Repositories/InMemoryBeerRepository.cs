using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkumOgSandhed.Domain.Entities;
using SkumOgSandhed.Application.Interfaces;

namespace SkumOgSandhed.Persistence.Repositories
{
    public class InMemoryBeerRepository : IBeerRepository
{
    private readonly List<Beer> _beers = new()
    {
        new Beer { BeerId = 1, Name = "Tuborg Classic", ReleaseYear = 2024, DrinkingYear = 2025, Abv = 4.6m, FoodPairing = "None", Description = "Good", Fermentation = "Lager", YeastType = "Ale", Price = 50m, Rating = 4.5m, UntappdRating = 3.2m },
        new Beer { BeerId = 2, Name = "Royal Classic", ReleaseYear = 2024, DrinkingYear = 2025, Abv = 4.6m, FoodPairing = "Alt", Description = "Very Good", Fermentation = "Lager", YeastType = "Ale", Price = 50m, Rating = 4.5m, UntappdRating = 3.2m },
    };

    public Task<IReadOnlyList<Beer>> GetAllAsync() => Task.FromResult((IReadOnlyList<Beer>)_beers);
}

}