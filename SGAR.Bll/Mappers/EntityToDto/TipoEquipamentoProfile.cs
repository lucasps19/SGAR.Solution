using AutoMapper;
using SGAR.Dto.Equipamento;
using SGAR.Model.Models;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class TipoEquipamentoProfile : Profile
    {
        public TipoEquipamentoProfile()
        {
            CreateMap<TipoEquipamento, TipoEquipamentoDto>().ReverseMap();
        }
    }
}
