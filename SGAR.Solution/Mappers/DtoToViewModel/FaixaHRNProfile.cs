using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.WebApi.ViewModel.HRN;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    public class FaixaHRNProfile : Profile
    {
        public FaixaHRNProfile()
        {
            CreateMap<FaixaHRNDto, FaixaHRNViewModel>().ReverseMap();
        }
    }
}
