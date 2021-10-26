using AutoMapper;
using SGAR.Dal.NovaApreciacao;
using SGAR.Dto.Equipamento;
using SGAR.Model.Models;
using System.Collections.Generic;

namespace SGAR.Bll.NovaApreciacao
{
    public class NovaApreciacaoBll
    {
        private readonly NovaApreciacaoDal _novaApreciacaoDal;
        private readonly IMapper _mapper;

        public NovaApreciacaoBll(NovaApreciacaoDal novaApreciacaoDal, IMapper mapper)
        {
            _novaApreciacaoDal = novaApreciacaoDal;
            _mapper = mapper;
        }

        public List<EquipamentoDto> BuscarEquipamentos()
        {
            return _mapper.Map<List<Equipamento>, List<EquipamentoDto>>(_novaApreciacaoDal.BuscarEquipamentos());
        }
    }
}
