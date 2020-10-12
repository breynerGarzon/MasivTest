using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Masiv.Data.Interfaces;
using Masiv.Model.Models;
using Microsoft.Extensions.Options;

namespace Masiv.Data.Services
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppSettings AppSettingsOptions;
        public ClientRepository(IOptions<AppSettings> _appSettingsOptions)
        {
            this.AppSettingsOptions = _appSettingsOptions.Value;
        }

        public Client Create(Client entity)
        {
            try
            {
                using (var connection = new SqlConnection(this.AppSettingsOptions.ConnectionString))
                {
                    var queryParameters = new DynamicParameters();
                    queryParameters.Add("@ClientName", entity.ClientName);
                    queryParameters.Add("@ClientLastName", entity.ClientLastName);
                    queryParameters.Add("@ClientBalance", entity.ClientBalance);
                    string response = connection.Query<string>("CreateClient", queryParameters, commandType: CommandType.StoredProcedure).First();
                    return entity;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public Client Delete(Client entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Client> Find(QueryFilter filters)
        {
            try
            {
                using (var connection = new SqlConnection(this.AppSettingsOptions.ConnectionString))
                {
                    return connection.Query<Client>("GetClients").ToList();
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public Client Update(Client entity)
        {
            throw new System.NotImplementedException();
        }
    }
}