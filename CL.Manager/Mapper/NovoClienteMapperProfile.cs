using AutoMapper;
using CL.Core.Domain;
using CL.Core.Shared.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Mapper
{
    public class NovoClienteMapperProfile : Profile
    {

        public NovoClienteMapperProfile()
        {
            CreateMap<NovoCliente, Cliente>();
        }


    }
}
