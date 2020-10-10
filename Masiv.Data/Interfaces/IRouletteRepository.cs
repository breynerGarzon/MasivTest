using Masiv.Model.Models;

namespace Masiv.Data.Interfaces
{
    public interface IRouletteRepository : IRepositoryBase<Roulette>
    {
        string EnableRoulette(int rouletteId);
        string DisableRoulette(int rouletteId);

    }
}