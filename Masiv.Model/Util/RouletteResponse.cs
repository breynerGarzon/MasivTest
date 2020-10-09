using System.Collections.Generic;
using System.Net;
using Masiv.Model.Views;

namespace Masiv.Model.Util
{
    public static class RouletteResponse
    {
        public static ModelResponse<int> CreationProcedureOk(int rouletteId) => new ModelResponse<int>() { StatusCode = HttpStatusCode.OK, Item = rouletteId, Data = null, Message = null };
        public static ModelResponse<int> CreationProcedureInternalError(string messageError) => new ModelResponse<int>() { StatusCode = HttpStatusCode.InternalServerError, Item = 0, Data = null, Message = messageError };
        public static ModelResponse<ViewRouletteBets> DisableRouletteProcedureOk(IEnumerable<ViewRouletteBets> roulettes) => new ModelResponse<ViewRouletteBets>() { StatusCode = HttpStatusCode.OK, Item = null, Data = roulettes, Message = null };
        public static ModelResponse<ViewRouletteBets> DisableRouletteProcedureInternalError(string messageError) => new ModelResponse<ViewRouletteBets>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };
        public static ModelResponse<string> EnableRouletteProcedureOk(string message) => new ModelResponse<string>() { StatusCode = HttpStatusCode.OK, Item = message, Data = null, Message = null };
        public static ModelResponse<string> EnableRouletteProcedureInternalError(string messageError) => new ModelResponse<string>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };
        public static ModelResponse<string> GetRoulettesProcedureOk(string message) => new ModelResponse<string>() { StatusCode = HttpStatusCode.OK, Item = message, Data = null, Message = null };
        public static ModelResponse<string> GetRoulettesProcedureInternalError(string messageError) => new ModelResponse<string>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };
    }
}