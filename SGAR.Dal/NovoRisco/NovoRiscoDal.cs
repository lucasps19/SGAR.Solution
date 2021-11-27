using SGAR.Model.Contexto;
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
    }
}
