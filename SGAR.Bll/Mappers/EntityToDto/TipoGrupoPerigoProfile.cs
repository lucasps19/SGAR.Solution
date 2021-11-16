using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.Model.Models.NR12100;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class TipoGrupoPerigoProfile : Profile
    {
        public TipoGrupoPerigoProfile()
        {
            CreateMap<TipoGrupoPerigo, TipoGrupoPerigoDto>().ReverseMap();
        }
    }
}
