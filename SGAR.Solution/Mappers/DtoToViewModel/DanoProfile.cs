using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.WebApi.ViewModel.NR12100;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class DanoProfile : Profile
    {
        public DanoProfile()
        {
            CreateMap<DanoDto, DanoViewModel>().ReverseMap();
        }
    }
}
