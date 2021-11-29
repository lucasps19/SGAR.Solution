using AutoMapper;
using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.WebApi.ViewModel.Categoria_e_Performance_Level;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    public class CategoriaPerformanceLevelRequeridoProfile : Profile
    {
        public CategoriaPerformanceLevelRequeridoProfile()
        {
            CreateMap<CategoriaPerformanceLevelRequeridoDto, CategoriaPerformanceLevelRequeridoViewModel>().ReverseMap();
        }
    }
}
