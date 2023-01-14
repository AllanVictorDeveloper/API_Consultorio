using CL.Data.Repository;
using CL.Manager.Implementation;
using CL.Manager.Interfaces;
using System.Collections;

namespace CL.WebApi.Configuration
{
    public static class DependencyInjector
    {

        public static void AddDependencyInjectorConfiguration(this IServiceCollection services )
        {

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteManager, ClienteManager>();
        }

    }
}
