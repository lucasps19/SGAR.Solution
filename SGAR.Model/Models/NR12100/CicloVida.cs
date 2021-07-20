using System.Collections.Generic;

namespace SGAR.Model.Models.NR12100
{
    public class CicloVida : BaseEntity
    {
        public CicloVida()
        {
            Tarefas = new List<Tarefa>();
            Riscos = new List<Risco>();
        }

        public string Descricao { get; set; }
        public List<Tarefa> Tarefas { get; set; }
        public List<Risco> Riscos { get; set; }
    }
}
