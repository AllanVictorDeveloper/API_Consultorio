using CL.Manager.Mapper;

namespace CL.WebApi.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(NovoClienteMapperProfile), typeof(AlteraClienteMapperProfile));
        }

    }
}
