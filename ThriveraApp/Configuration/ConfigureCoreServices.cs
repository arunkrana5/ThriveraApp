using Core.Interfaces;
using Infrastructure.DataAccess;
using Services.BusinessLogic;

namespace ThriveraApp.Configuration
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            // Authentication & Authorization 
            services.AddSingleton<DapperDBContext>();
            services.AddScoped<IAccountServices, AccountServices>();
            return services;
        }
    }
}
