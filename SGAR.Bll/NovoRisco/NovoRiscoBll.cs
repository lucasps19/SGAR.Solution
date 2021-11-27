using AutoMapper;
using SGAR.Dal.NovoRisco;
using SGAR.Dto.NR12100;
using SGAR.Model.Models.NR12100;
using System.Collections.Generic;

namespace SGAR.Bll.NovoRisco
{
    public class NovoRiscoBll
    {
        private readonly NovoRiscoDal _novoRiscoDal;
        private readonly IMapper _mapper;

        public NovoRiscoBll(NovoRiscoDal novoRiscoDal, IMapper mapper)
        {
            _novoRiscoDal = novoRiscoDal;
            _mapper = mapper;
        }

        public List<CicloVidaDto> BuscarCicloVida()
        {
            return _mapper.Map<List<CicloVida>, List<CicloVidaDto>>(_novoRiscoDal.BuscarCicloVida());
        }
    }
}
