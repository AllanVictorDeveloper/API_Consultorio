using CL.Manager.Validator;
using FluentValidation.AspNetCore;
using System.Globalization;

namespace CL.WebApi.Configuration
{
    public static class FluentValidatorConfig
    {
        [Obsolete]
        public static void AddFluentValidatorConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(p =>
            {
                p.RegisterValidatorsFromAssemblyContaining<NovoClienteValidator>();
                p.RegisterValidatorsFromAssemblyContaining<AlteraClienteValidator>();
                p.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-br");
            });
        }

    }
}
