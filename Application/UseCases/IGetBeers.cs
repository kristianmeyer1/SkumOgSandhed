using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkumOgSandhed.Domain.Entities;

namespace SkumOgSandhed.Application.UseCases
{
    public interface IGetBeers
    {
        Task<IReadOnlyList<Beer>> ExecuteAsync();
    }
}