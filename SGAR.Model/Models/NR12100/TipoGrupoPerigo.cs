using System.Collections.Generic;

namespace SGAR.Model.Models.NR12100
{
    public class TipoGrupoPerigo : BaseEntity
    {
        public TipoGrupoPerigo()
        {
            Danos = new List<Dano>();
            Riscos = new List<Risco>();
        }

        public string Descricao { get; set; }
        public List<Dano> Danos { get; set; }
        public List<Risco> Riscos { get; set; }
    }
}
