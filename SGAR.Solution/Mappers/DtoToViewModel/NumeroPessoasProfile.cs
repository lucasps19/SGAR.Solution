using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.WebApi.ViewModel.HRN;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class NumeroPessoasProfile : Profile
    {
        public NumeroPessoasProfile()
        {
            CreateMap<NumeroPessoasDto, NumeroPessoasViewModel>().ReverseMap();
        }
    }
}
