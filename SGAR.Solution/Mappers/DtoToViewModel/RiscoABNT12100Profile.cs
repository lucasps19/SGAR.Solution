using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.WebApi.ViewModel.NR12100;

namespace SGAR.WebApi.Mappers
{
    class RiscoABNT12100Profile : Profile
    {
        public RiscoABNT12100Profile()
        {
            CreateMap<RiscoABNT12100Dto, RiscoABNT12100ViewModel>().ReverseMap();
        }
    }
}
