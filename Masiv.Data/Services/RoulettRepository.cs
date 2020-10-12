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
    public class RoulettRepository : IRouletteRepository
    {
        private readonly AppSettings AppSettingsOptions;
        public RoulettRepository(IOptions<AppSettings> _appSettingsOptions)
        {
            this.AppSettingsOptions = _appSettingsOptions.Value;
        }

        public Roulette Create(Roulette entity)
        {
            using (var connection = new SqlConnection(this.AppSettingsOptions.ConnectionString))
            {
                var orderDetails = connection.Query<Roulette>("CreateRoulette");
                entity.Id = orderDetails.First().Id;

                return entity;
            }
        }

        public Roulette Delete(Roulette entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<RouletteBets> DisableRoulette(int rouletteId)
        {
            using (var connection = new SqlConnection(this.AppSettingsOptions.ConnectionString))
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@RouletteId", rouletteId);
                IEnumerable<RouletteBets> response = connection.Query<RouletteBets>("DisableRoulette", queryParameters, commandType: CommandType.StoredProcedure)
                                                .ToList();

                return response;
            }
        }

        public string EnableRoulette(int rouletteId)
        {
            using (var connection = new SqlConnection(this.AppSettingsOptions.ConnectionString))
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@RouletteId", rouletteId);
                string message = connection.Query<string>("EnableRoulette", queryParameters, commandType: CommandType.StoredProcedure)
                                                .ToList()
                                                .First();

                return message;
            }
        }
        public IEnumerable<Roulette> Find(QueryFilter filters)
        {
            using (var connection = new SqlConnection(this.AppSettingsOptions.ConnectionString))
            {
                return connection.Query<Roulette>("GetRoulettes").ToList();
            }
        }

        public Roulette Update(Roulette entity)
        {
            throw new System.NotImplementedException();
        }
    }
}