using System.Collections.Generic;
using Masiv.Business.Business;
using Masiv.Business.Interfaces;
using Masiv.Data.Interfaces;
using Masiv.Model.Models;
using Masiv.Model.Util;
using Masiv.Model.Views;
using Serilog;

namespace Masiv.Business.Services
{
    public class RouletteBusinessServices : IRouletteBusinessServices
    {
        private readonly IRouletteRepository DataServices;
        public RouletteBusinessServices(IRouletteRepository dataServices)
        {
            this.DataServices = dataServices;
        }
        public ModelResponse<int> CreateRoulette()
        {
            try
            {
                return RouletteResponse.CreationProcedureOk(this.DataServices.Create(new Roulette()).Id);
            }
            catch (System.Exception ex)
            {
                Log.Error(ex, "An error occurred when registering a Roulette, error:");
                return RouletteResponse.CreationProcedureInternalError(Message.ERRORTOCREATEROULETTE);
            }
        }

        public ModelResponse<BettingSummary> DisableRoulette(int rouletteId)
        {
            try
            {
                IEnumerable<RouletteBets> bets = this.DataServices.DisableRoulette(rouletteId);
                RuletteBetResponse response = new RuletteBetResponse(bets);
                return RouletteResponse.DisableRouletteProcedureOk(response.GetSumaryOfBets());
            }
            catch (System.Exception ex)
            {
                Log.Error(ex, "An error occurred when disabling the roulette, error:");
                return RouletteResponse.DisableRouletteProcedureInternalError(Message.ERRORTODISABLEROULETTE);
            }
        }

        public ModelResponse<string> EnableRoulette(int rouletteId)
        {
            try
            {
                return RouletteResponse.EnableRouletteProcedureOk(this.DataServices.EnableRoulette(rouletteId));
            }
            catch (System.Exception ex)
            {
                Log.Error(ex, "An error occurred when enabling  the roulette, error:");
                return RouletteResponse.EnableRouletteProcedureInternalError(Message.ERRORTOENABLEROULETTE);
            }
        }

        public ModelResponse<Roulette> GetRoulettes()
        {
            try
            {
                return RouletteResponse.GetRoulettesProcedureOk(this.DataServices.Find(new QueryFilter()));
            }
            catch (System.Exception ex)
            {
                Log.Error(ex, "An error occurred when consulting the roulettes, error:");
                return RouletteResponse.GetRoulettesProcedureInternalError(Message.ERRORTOGETROULETTES);
            }
        }
    }
}