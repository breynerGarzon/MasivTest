using System.Net;
using Masiv.Model.Views;

namespace Masiv.Model.Util
{
    public static class BetResponse
    {
        public static ModelResponse<string> CreationProcedureOk(string message) => new ModelResponse<string>() { StatusCode = HttpStatusCode.OK, Item = message, Data = null, Message = null };
        public static ModelResponse<string> CreationProcedureInternalError(string messageError) => new ModelResponse<string>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };
    }
}