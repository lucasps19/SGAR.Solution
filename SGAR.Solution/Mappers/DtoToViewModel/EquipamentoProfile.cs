using AutoMapper;
using SGAR.Dto.Equipamento;
using SGAR.WebApi.ViewModel.Equipamento;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    public class EquipamentoProfile : Profile
    {
        public EquipamentoProfile()
        {
            CreateMap<EquipamentoDto, EquipamentoViewModel>()
                .ForMember(dest => dest.IdEmpresa, map => map.MapFrom(src => src.IdEmpresa))
                .ForMember(dest => dest.IdTipoEquipamento, map => map.MapFrom(src => src.IdTipoEquipamento))
                .ReverseMap();
        }
    }
}
