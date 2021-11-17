using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.Model.Models.HRN;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class HRNDepoisProfile : Profile
    {
        public HRNDepoisProfile()
        {
            CreateMap<HRNDepois, HRNDepoisDto>().ReverseMap();
        }
    }
}
