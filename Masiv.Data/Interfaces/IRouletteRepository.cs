using Masiv.Model.Models;

namespace Masiv.Data.Interfaces
{
    public interface IRouletteRepository : IRepositoryBase<Roulette>
    {
        bool EnableRoulette(int rouletteId);
        bool DisableRoulette(int rouletteId);

    }
}