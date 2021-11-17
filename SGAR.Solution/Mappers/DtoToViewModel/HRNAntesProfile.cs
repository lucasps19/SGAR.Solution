using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.WebApi.ViewModel.HRN;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class HRNAntesProfile : Profile
    {
        public HRNAntesProfile()
        {
            CreateMap<HRNAntesDto, HRNAntesViewModel>().ReverseMap();
        }
    }
}
