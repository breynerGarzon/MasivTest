using System.Collections.Generic;
using System.Net;
using Masiv.Model.Models;
using Masiv.Model.Views;

namespace Masiv.Model.Util
{
    public static class RouletteResponse
    {
        public static ModelResponse<int> CreationProcedureOk(int rouletteId) => new ModelResponse<int>() { StatusCode = HttpStatusCode.OK, Item = rouletteId, Data = null, Message = null };
        public static ModelResponse<int> CreationProcedureInternalError(string messageError) => new ModelResponse<int>() { StatusCode = HttpStatusCode.InternalServerError, Item = 0, Data = null, Message = messageError };
        public static ModelResponse<BettingSummary> DisableRouletteProcedureOk(BettingSummary dataBets) => new ModelResponse<BettingSummary>() { StatusCode = HttpStatusCode.OK, Item = dataBets, Data = null, Message = null };
        public static ModelResponse<BettingSummary> DisableRouletteProcedureInternalError(string messageError) => new ModelResponse<BettingSummary>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };
        public static ModelResponse<string> EnableRouletteProcedureOk(string message) => new ModelResponse<string>() { StatusCode = HttpStatusCode.OK, Item = message, Data = null, Message = null };
        public static ModelResponse<string> EnableRouletteProcedureInternalError(string messageError) => new ModelResponse<string>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };
        public static ModelResponse<Roulette> GetRoulettesProcedureOk(IEnumerable<Roulette> roulettes) => new ModelResponse<Roulette>() { StatusCode = HttpStatusCode.OK, Item = null, Data = roulettes, Message = null };
        public static ModelResponse<Roulette> GetRoulettesProcedureInternalError(string messageError) => new ModelResponse<Roulette>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };
    }
}