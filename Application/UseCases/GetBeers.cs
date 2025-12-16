using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkumOgSandhed.Application.Interfaces;
using SkumOgSandhed.Domain.Entities;

namespace SkumOgSandhed.Application.UseCases
{
    public class GetBeers : IGetBeers
    {
        private readonly IBeerRepository _beerRepository;

        public GetBeers(IBeerRepository beerRepository)
        {
            _beerRepository = beerRepository;
        }

        public async Task<IReadOnlyList<Beer>> ExecuteAsync()
        {
            var beers = await _beerRepository.GetAllAsync();

            return beers;
        }


    }
}