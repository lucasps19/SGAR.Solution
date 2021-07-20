using System.Collections.Generic;

namespace SGAR.Model.Models.NR12100
{
    public class Dano : BaseEntity
    {
        public Dano()
        {
            Riscos = new List<Risco>();
        }

        public string Descricao { get; set; }
        public int IdTipoGrupoPerigo { get; set; }
        public TipoGrupoPerigo TipoGrupoPerigo { get; set; }
        public List<Risco> Riscos { get; set; }
    }
}
