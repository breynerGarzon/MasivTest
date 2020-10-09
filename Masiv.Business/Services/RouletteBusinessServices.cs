using System.Collections.Generic;
using Masiv.Business.Interfaces;
using Masiv.Data.Interfaces;
using Masiv.Model.Util;
using Masiv.Model.Views;

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
                return RouletteResponse.CreationProcedureOk(this.DataServices.Create());
            }
            catch (System.Exception)
            {
                return RouletteResponse.CreationProcedureInternalError("Error al crear ruleta");
            }
        }

        public ModelResponse<ViewRouletteBets> DisableRoulette(int rouletteId)
        {
            try
            {
                return RouletteResponse.DisableRouletteProcedureOk(this.DataServices.DiableRoulette(rouletteId));
            }
            catch (System.Exception)
            {
                return RouletteResponse.DisableRouletteProcedureInternalError("");
            }
        }

        public ModelResponse<string> EnableRoulette(int rouletteId)
        {
            try
            {
                return RouletteResponse.EnableRouletteProcedureOk(this.DataServices.EnableRoulette(rouletteId));
            }
            catch (System.Exception)
            {
                return RouletteResponse.EnableRouletteProcedureInternalError("");
            }
        }

        public ModelResponse<string> GetRoulettes()
        {
            try
            {
                return RouletteResponse.EnableRouletteProcedureOk(this.DataServices.Find());
            }
            catch (System.Exception)
            {
                return RouletteResponse.EnableRouletteProcedureInternalError("");
            }
        }
    }
}