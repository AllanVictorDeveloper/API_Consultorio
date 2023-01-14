using AutoMapper;
using CL.Core.Domain;
using CL.Core.Shared.ModelViews;

namespace CL.Manager.Mapper
{
    public class AlteraClienteMapperProfile : Profile
    {
        public AlteraClienteMapperProfile()
        {
            CreateMap<AlteraCliente, Cliente>()
                .ForMember(d => d.UltimaAtualizacao, o => o.MapFrom(x => DateTime.Now))
                .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
        }
    }
}