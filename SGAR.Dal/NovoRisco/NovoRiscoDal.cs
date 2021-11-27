using SGAR.Model.Contexto;
using SGAR.Model.Models.HRN;
using SGAR.Model.Models.NR12100;
using System.Collections.Generic;
using System.Linq;

namespace SGAR.Dal.NovoRisco
{
    public class NovoRiscoDal
    {
        private readonly Contexto _contexto;

        public NovoRiscoDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<CicloVida> BuscarCicloVida()
        {
            return _contexto.CiclosDeVida.ToList();
        }

        public List<Tarefa> BuscarTarefas(int idCicloVida)
        {
            return _contexto.Tarefas.Where(o => o.IdCicloVida == idCicloVida).ToList();
        }

        public List<TipoGrupoPerigo> BuscarTipoGrupoPerigo()
        {
            return _contexto.TiposGruposPerigo.ToList();
        }

        public List<Dano> BuscarDanos(int idTipoGrupoPerigo)
        {
            return _contexto.Danos.Where(o => o.IdTipoGrupoPerigo == idTipoGrupoPerigo).ToList();
        }

        public List<RiscoABNT12100> BuscarRiscosABNT12100()
        {
            return _contexto.RiscosABNT.ToList();
        }

        public List<GrauPossivelLesao> BuscarGLPHRN()
        {
            return _contexto.GrauPossiveisLesoes.ToList();
        }

        public List<PossibilidadeOcorrencia> BuscarPOHRN()
        {
            return _contexto.PossibilidadesOcorrencia.ToList();
        }

        public List<FrequenciaExposicao> BuscarFEHRN()
        {
            return _contexto.FrequenciasExposicao.ToList();
        }

        public List<NumeroPessoas> BuscarNPHRN()
        {
            return _contexto.NumerosPessoas.ToList();
        }

        public List<FaixaHRN> BuscarFaixasHRN()
        {
            return _contexto.FaixasHRN.ToList();
        }
    }
}
