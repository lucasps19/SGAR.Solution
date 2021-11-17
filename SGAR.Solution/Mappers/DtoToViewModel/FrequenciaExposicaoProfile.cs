using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.WebApi.ViewModel.HRN;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class FrequenciaExposicaoProfile : Profile
    {
        public FrequenciaExposicaoProfile()
        {
            CreateMap<FrequenciaExposicaoDto, FrequenciaExposicaoViewModel>().ReverseMap();
        }
    }
}
