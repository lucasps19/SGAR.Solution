using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.Model.Models.HRN;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class FaixaHRNProfile : Profile
    {
        public FaixaHRNProfile()
        {
            CreateMap<FaixaHRN, FaixaHRNDto>().ReverseMap();
        }
    }
}
