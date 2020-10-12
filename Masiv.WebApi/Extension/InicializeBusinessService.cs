using Masiv.Business.Interfaces;
using Masiv.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Masiv.WebApi.Extension
{
    public static class InicializeBusinessService
    {
        public static void ConfigureBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IRouletteBusinessServices, RouletteBusinessServices>();
            services.AddScoped<IBetBusinessServices, BetBusinessServices>();
            services.AddScoped<IClientBusinessServices, ClientBusinessServices>();
        }
    }
}