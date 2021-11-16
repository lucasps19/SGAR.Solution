using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.WebApi.ViewModel.NR12100;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class CicloVidaProfile : Profile
    {
        public CicloVidaProfile()
        {
            CreateMap<CicloVidaDto, CicloVidaViewModel>().ReverseMap();
        }
    }
}
