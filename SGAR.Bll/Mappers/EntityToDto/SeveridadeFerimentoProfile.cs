using AutoMapper;
using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.Model.Models.Categoria_e_Performance_Level;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class SeveridadeFerimentoProfile : Profile
    {
        public SeveridadeFerimentoProfile()
        {
            CreateMap<SeveridadeFerimento, SeveridadeFerimentoDto>().ReverseMap();
        }
    }
}
