using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.WebApi.ViewModel.HRN;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class GrauPossivelLesaoProfile : Profile
    {
        public GrauPossivelLesaoProfile()
        {
            CreateMap<GrauPossivelLesaoDto, GrauPossivelLesaoViewModel>().ReverseMap();
        }
    }
}
