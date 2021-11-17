using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.Model.Models.HRN;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class HRNAntesProfile : Profile
    {
        public HRNAntesProfile()
        {
            CreateMap<HRNAntes, HRNAntesDto>().ReverseMap();
        }
    }
}
