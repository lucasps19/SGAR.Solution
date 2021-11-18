using AutoMapper;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class RiscoProfile : Profile
    {
        public RiscoProfile()
        {
            CreateMap<RiscoDto, RiscoViewModel>().ReverseMap();
        }
    }
}
