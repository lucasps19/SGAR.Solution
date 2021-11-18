using AutoMapper;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Model.Models;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class RiscoProfile : Profile
    {
        public RiscoProfile()
        {
            CreateMap<Risco, RiscoDto>().ReverseMap();
        }
    }
}
