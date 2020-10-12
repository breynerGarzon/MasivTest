using System.Collections.Generic;
using System.Net;
using Masiv.Model.Models;
using Masiv.Model.Views;

namespace Masiv.Model.Util
{
    public static class ClientResponse
    {
        public static ModelResponse<string> CreationProcedureOk(string clientName) => new ModelResponse<string>() { StatusCode = HttpStatusCode.OK, Item = clientName, Data = null, Message = null };
        public static ModelResponse<string> CreationProcedureInternalError(string messageError) => new ModelResponse<string>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };

        public static ModelResponse<Client> GetProcedureOk(IEnumerable<Client> clients) => new ModelResponse<Client>() { StatusCode = HttpStatusCode.OK, Item = null, Data =clients, Message = null };
        public static ModelResponse<Client> GetProcedureInternalError(string messageError) => new ModelResponse<Client>() { StatusCode = HttpStatusCode.InternalServerError, Item = null, Data = null, Message = messageError };
    }
}