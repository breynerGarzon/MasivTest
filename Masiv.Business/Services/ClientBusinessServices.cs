using System.Collections.Generic;
using Masiv.Business.Interfaces;
using Masiv.Data.Interfaces;
using Masiv.Model.Models;
using Masiv.Model.Util;
using Masiv.Model.Views;
using Serilog;

namespace Masiv.Business.Services
{
    public class ClientBusinessServices : IClientBusinessServices
    {
        private readonly IClientRepository ClientRepository;
        public ClientBusinessServices(IClientRepository clientRepository)
        {
            this.ClientRepository = clientRepository;
        }
        public ModelResponse<string> CreateClient(Client dataNewClient)
        {
            try
            {
                return ClientResponse.CreationProcedureOk(this.ClientRepository.Create(dataNewClient).ClientName);
            }
            catch (System.Exception ex)
            {
                Log.Error(ex, "An error occurred when registering a user, error:");
                return ClientResponse.CreationProcedureInternalError(Message.ERRORTOCREATECLIENT);
            }
        }

        public ModelResponse<Client> GetClients()
        {
            try
            {
                return ClientResponse.GetProcedureOk(this.ClientRepository.Find(new QueryFilter()));
            }
            catch (System.Exception ex)
            {
                Log.Error(ex, "An error occurred when consulting the clients, error:");
                return ClientResponse.GetProcedureInternalError(Message.ERRORTOGETCLIENT);
            }
        }
    }
}