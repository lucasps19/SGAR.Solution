using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.Model.Models.NR12100;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class CicloVidaProfile : Profile
    {
        public CicloVidaProfile()
        {
            CreateMap<CicloVida, CicloVidaDto>().ReverseMap();
        }
    }
}
