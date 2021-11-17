using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.Model.Models.HRN;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class GrauPossivelLesaoProfile : Profile
    {
        public GrauPossivelLesaoProfile()
        {
            CreateMap<GrauPossivelLesao, GrauPossivelLesaoDto>().ReverseMap();
        }
    }
}
