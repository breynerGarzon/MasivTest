using Masiv.Business.Interfaces;
using Masiv.Data.Interfaces;
using Masiv.Model.Util;
using Masiv.Model.Views;

namespace Masiv.Business.Services
{
    public class BetBusinessServices : IBetBusinessServices
    {
        private readonly IBetRepository RepositoryBet;
        public BetBusinessServices(IBetRepository repositoryBet)
        {
            this.RepositoryBet = repositoryBet;
        }

        public ModelResponse<string> CreateBet(ViewBetRequest newBet, string clientId)
        {
            try
            {
                newBet.ClientId = int.Parse(clientId);
                return BetResponse.CreationProcedureOk(this.RepositoryBet.Create(newBet).Message);
            }
            catch (System.Exception)
            {
                return BetResponse.CreationProcedureInternalError("");
            }
        }
    }
}