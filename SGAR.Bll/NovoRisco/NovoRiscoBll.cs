﻿using AutoMapper;
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

        public List<TarefaDto> BuscarTarefas(int idCicloVida)
        {
            return _mapper.Map<List<Tarefa>, List<TarefaDto>>(_novoRiscoDal.BuscarTarefas(idCicloVida));
        }

        public List<TipoGrupoPerigoDto> BuscarTipoGrupoPerigo()
        {
            return _mapper.Map<List<TipoGrupoPerigo>, List<TipoGrupoPerigoDto>>(_novoRiscoDal.BuscarTipoGrupoPerigo());
        }

        public List<DanoDto> BuscarDanos(int idTipoGrupoPerigo)
        {
            return _mapper.Map<List<Dano>, List<DanoDto>>(_novoRiscoDal.BuscarDanos(idTipoGrupoPerigo));
        }

        public List<RiscoABNT12100Dto> BuscarRiscosABNT12100()
        {
            return _mapper.Map<List<RiscoABNT12100>, List<RiscoABNT12100Dto>>(_novoRiscoDal.BuscarRiscosABNT12100());
        }
    }
}
