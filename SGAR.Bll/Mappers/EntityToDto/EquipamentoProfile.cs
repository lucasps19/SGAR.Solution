using AutoMapper;
using SGAR.Dto.Equipamento;
using SGAR.Model.Models;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class EquipamentoProfile : Profile
    {
        public EquipamentoProfile()
        {
            CreateMap<Equipamento, EquipamentoDto>()
                .ForMember(dest => dest.IdEmpresa, map => map.MapFrom(src => src.IdEmpresa))
                .ForMember(dest => dest.IdTipoEquipamento, map => map.MapFrom(src => src.IdTipoEquipamento))
                .ReverseMap();
        }
    }
}
