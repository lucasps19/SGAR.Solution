using System.Collections.Generic;

namespace SGAR.Model.Models.NR12100
{
    public class Tarefa : BaseEntity
    {
        public Tarefa()
        {
            Riscos = new List<Risco>();
        }

        public string Descricao { get; set; }
        public int IdCicloVida { get; set; }
        public CicloVida CicloVida { get; set; }
        public List<Risco> Riscos { get; set; }
    }
}
