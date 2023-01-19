using AutoMapper;
using CL.Core.Domain;
using CL.Core.Shared.ModelViews;

namespace CL.Manager.Mapper
{
    public class NovoClienteMapperProfile : Profile
    {
        public NovoClienteMapperProfile()
        {
            CreateMap<NovoCliente, Cliente>()
                .ForMember(d => d.Criacao, o => o.MapFrom(x => DateTime.Now))
                .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));


            CreateMap<NovoEndereco, Endereco>();
                
        }
    }
}