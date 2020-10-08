using System.Collections.Generic;
using Masiv.Model.Views;

namespace Masiv.Business.Interfaces
{
    public interface IRouletteBusinessServices
    {
        int CreateRoulette();
        string EnableRoulette(int rouletteId);
        IEnumerable<ViewRouletteBets> DisableRoulette(int rouletteId);
        string GetRoulettes();

    }
}