using System.Collections.Generic;
using Masiv.Model.Views;

namespace Masiv.Business.Interfaces
{
    public interface IRouletteBusinessServices
    {
        ModelResponse<int> CreateRoulette();
        ModelResponse<string> EnableRoulette(int rouletteId);
        ModelResponse<ViewRouletteBets> DisableRoulette(int rouletteId);
        ModelResponse<string> GetRoulettes();
    }
}