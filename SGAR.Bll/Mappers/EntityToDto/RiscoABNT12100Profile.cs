using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.Model.Models.NR12100;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class RiscoABNT12100Profile : Profile
    {
        public RiscoABNT12100Profile()
        {
            CreateMap<RiscoABNT12100, RiscoABNT12100Dto>().ReverseMap();
        }
    }
}
