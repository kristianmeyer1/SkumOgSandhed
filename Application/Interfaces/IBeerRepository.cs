using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkumOgSandhed.Domain.Entities;

namespace SkumOgSandhed.Application.Interfaces
{
    public interface IBeerRepository
    {
        Task<IReadOnlyList<Beer>> GetAllAsync();
    }
}