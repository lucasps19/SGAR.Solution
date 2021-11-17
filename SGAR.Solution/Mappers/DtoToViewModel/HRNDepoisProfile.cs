using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.WebApi.ViewModel.HRN;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class HRNDepoisProfile : Profile
    {
        public HRNDepoisProfile()
        {
            CreateMap<HRNDepoisDto, HRNDepoisViewModel>().ReverseMap();
        }
    }
}
