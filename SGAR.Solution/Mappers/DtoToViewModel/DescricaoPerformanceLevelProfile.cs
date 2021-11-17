using AutoMapper;
using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.WebApi.ViewModel.Categoria_e_Performance_Level;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class DescricaoPerformanceLevelProfile : Profile
    {
        public DescricaoPerformanceLevelProfile()
        {
            CreateMap<DescricaoPerformanceLevelDto, DescricaoPerformanceLevelViewModel>().ReverseMap();
        }
    }
}
