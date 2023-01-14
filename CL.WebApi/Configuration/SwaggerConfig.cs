using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace CL.WebApi.Configuration
{
    public static class SwaggerConfig
    {
        [Obsolete]
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Consultorio Legal", Version = "v1" });

                //c.AddFluentValidationRules();
            });
        }

        public static void AppSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}