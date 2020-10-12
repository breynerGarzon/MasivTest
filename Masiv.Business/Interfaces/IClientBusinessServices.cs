using System.Collections.Generic;
using Masiv.Model.Models;
using Masiv.Model.Views;

namespace Masiv.Business.Interfaces
{
    public interface IClientBusinessServices
    {
        ModelResponse<string> CreateClient(Client dataNewClient);
        ModelResponse<Client> GetClients();
    }
}