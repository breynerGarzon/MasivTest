using Masiv.Model.Views;

namespace Masiv.Business.Interfaces
{
    public interface IBetBusinessServices
    {
        ModelResponse<string> CreateBet(ViewBetRequest newBet, string clientId);
    }
}