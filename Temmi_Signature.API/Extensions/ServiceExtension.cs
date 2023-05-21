using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using Temmie_Signature.Service.Interfaces;
using Temmie_Signature.Service.Services;

namespace Temmi_Signature.API.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureLoggerService(this IServiceCollection services) =>
             services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigiureRepositoryandServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region REGISTER SERVICES


            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            #endregion
        }

    }
}
