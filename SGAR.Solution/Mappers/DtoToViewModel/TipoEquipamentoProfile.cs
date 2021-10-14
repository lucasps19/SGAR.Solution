using AutoMapper;
using SGAR.Dto.Equipamento;
using SGAR.WebApi.ViewModel.Equipamento;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class TipoEquipamentoProfile : Profile
    {
        public TipoEquipamentoProfile()
        {
            CreateMap<TipoEquipamentoDto, TipoEquipamentoViewModel>().ReverseMap();
        }
    }
}
