using CL.Core.Domain;
using CL.Core.Shared.ModelViews;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Validator
{
    public class NovoClienteValidator : AbstractValidator<NovoCliente>
    {
        public NovoClienteValidator()
        {
            RuleFor(x =>x.Nome).NotEmpty().NotNull().MinimumLength(10).MaximumLength(150);
            RuleFor(x => x.DataNascimento).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(x => x.Documento).NotNull().NotEmpty().MinimumLength(5).MaximumLength(11);
            RuleFor(x => x.Telefone).NotNull().NotEmpty().Matches("[1-9][0-9]{11}").MinimumLength(9).WithMessage("O telefone tem que ter o formato [1-9][0-9]{9}");
            RuleFor(x => x.Sexo).NotNull().NotEmpty().Must(isMorF).WithMessage("Sexo precisa ser M ou F");
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("O email é obrigatório");
        }

        

        private bool isMorF(char sexo)
        {
            return sexo == 'M' || sexo == 'F';
        }
    }
}
