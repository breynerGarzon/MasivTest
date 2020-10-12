using Masiv.Data.Interfaces;
using Masiv.Data.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Masiv.WebApi.Extension
{
    public static class InicializeDataServices
    {
        public static void ConfigureDataServices(this IServiceCollection services)
        {
            services.AddScoped<IRouletteRepository, RoulettRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IBetRepository, BetRepository>();
        }
    }
}