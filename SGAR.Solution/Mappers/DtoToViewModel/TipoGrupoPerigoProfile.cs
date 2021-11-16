using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.WebApi.ViewModel.NR12100;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class TipoGrupoPerigoProfile : Profile
    {
        public TipoGrupoPerigoProfile()
        {
            CreateMap<TipoGrupoPerigoDto, TipoGrupoPerigoViewModel>().ReverseMap();
        }
    }
}
