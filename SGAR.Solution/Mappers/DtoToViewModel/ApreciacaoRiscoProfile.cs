using AutoMapper;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    public class ApreciacaoRiscoProfile : Profile
    {
        public ApreciacaoRiscoProfile() 
        {
            CreateMap<ApreciacaoRiscoDto, ApreciacaoRiscoViewModel>().ReverseMap();
        }
    }
}
