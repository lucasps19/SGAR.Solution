using AutoMapper;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Model.Models;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class ApreciacaoRiscoProfile : Profile
    {
        public ApreciacaoRiscoProfile()
        {
            CreateMap<ApreciacaoRisco, ApreciacaoRiscoDto>().ReverseMap();
        }
    }
}
