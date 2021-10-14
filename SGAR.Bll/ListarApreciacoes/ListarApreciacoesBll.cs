using AutoMapper;
using SGAR.Dal.ListarApreciacoes;
using SGAR.Dto.Equipamento;
using SGAR.Model.Models;
using System.Collections.Generic;

namespace SGAR.Bll.ListarApreciacoes
{
    public class ListarApreciacoesBll
    {
        private readonly ListarApreciacoesDal _listarApreciacoesDal;
        private readonly IMapper _mapper;

        public ListarApreciacoesBll(ListarApreciacoesDal listarApreciacoesDal, IMapper mapper)
        {
            _listarApreciacoesDal = listarApreciacoesDal;
            _mapper = mapper;
        }

        public List<TipoEquipamentoDto> BuscarTiposEquipamentos()
        {
            return _mapper.Map<List<TipoEquipamento>, List<TipoEquipamentoDto>>(_listarApreciacoesDal.BuscarTiposEquipamentos());
        }
    }
}
