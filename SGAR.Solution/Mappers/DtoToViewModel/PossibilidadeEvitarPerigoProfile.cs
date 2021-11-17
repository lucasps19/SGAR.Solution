using AutoMapper;
using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.WebApi.ViewModel.Categoria_e_Performance_Level;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class PossibilidadeEvitarPerigoProfile : Profile
    {
        public PossibilidadeEvitarPerigoProfile()
        {
            CreateMap<PossibilidadeEvitarPerigoDto, PossibilidadeEvitarPerigoViewModel>().ReverseMap();
        }
    }
}
