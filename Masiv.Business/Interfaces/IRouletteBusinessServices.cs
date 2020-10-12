using System.Collections.Generic;
using Masiv.Model.Models;
using Masiv.Model.Views;

namespace Masiv.Business.Interfaces
{
    public interface IRouletteBusinessServices
    {
        ModelResponse<int> CreateRoulette();
        ModelResponse<string> EnableRoulette(int rouletteId);
        ModelResponse<BettingSummary> DisableRoulette(int rouletteId);
        ModelResponse<Roulette> GetRoulettes();
    }
}