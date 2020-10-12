using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Masiv.Data.Interfaces;
using Masiv.Model.Models;
using Masiv.Model.Views;
using Microsoft.Extensions.Options;

namespace Masiv.Data.Services
{
    public class BetRepository : IBetRepository
    {
        private readonly AppSettings AppSettingsOptions;
        public BetRepository(IOptions<AppSettings> _appSettingsOptions)
        {
            this.AppSettingsOptions = _appSettingsOptions.Value;
        }

        public ViewBetRequest Create(ViewBetRequest entity)
        {
            try
            {
                using (var connection = new SqlConnection(this.AppSettingsOptions.ConnectionString))
                {
                    var queryParameters = new DynamicParameters();
                    queryParameters.Add("@RouletteId", entity.RouletteId);
                    queryParameters.Add("@ClientId", entity.ClientId);
                    queryParameters.Add("@Date", entity.Date);
                    queryParameters.Add("@ColorBet", (int)entity.ColorBet);
                    queryParameters.Add("@BetNumber", entity.BetNumber);
                    queryParameters.Add("@BetAmount", entity.BetAmount);
                    string response = connection.Query<string>("CreateBet", queryParameters, commandType: CommandType.StoredProcedure).First();
                    entity.Message = response;
                    return entity;
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public ViewBetRequest Delete(ViewBetRequest entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ViewBetRequest> Find(QueryFilter filters)
        {
            throw new System.NotImplementedException();
        }

        public ViewBetRequest Update(ViewBetRequest entity)
        {
            throw new System.NotImplementedException();
        }
    }
}