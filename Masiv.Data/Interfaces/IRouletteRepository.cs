using System.Collections.Generic;
using Masiv.Model.Models;

namespace Masiv.Data.Interfaces
{
    public interface IRouletteRepository : IRepositoryBase<Roulette>
    {
        string EnableRoulette(int rouletteId);
        IEnumerable<RouletteBets> DisableRoulette(int rouletteId);
    }
}