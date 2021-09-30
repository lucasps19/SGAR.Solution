using AutoMapper;
using SGAR.Dto.Pessoa;
using SGAR.Model.Models;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<Pessoa, PessoaDTO>()
                .ForMember(dest => dest.IdEmpresa, map => map.MapFrom(src => src.IdEmpresa))
                .ReverseMap();
        }
    }
}
