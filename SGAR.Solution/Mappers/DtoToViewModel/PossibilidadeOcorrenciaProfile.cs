using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.WebApi.ViewModel.HRN;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class PossibilidadeOcorrenciaProfile : Profile
    {
        public PossibilidadeOcorrenciaProfile()
        {
            CreateMap<PossibilidadeOcorrenciaDto, PossibilidadeOcorrenciaViewModel>().ReverseMap();
        }
    }
}
