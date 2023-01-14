using CL.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CL.WebApi.Configuration
{
    public static class DataBaseConfig
    {
        public static void AddDataBaaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CLContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("Connection")));
        }

    }
}
