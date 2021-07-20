using System.Collections.Generic;

namespace SGAR.Model.Models.NR12100
{
    public class RiscoABNT12100 : BaseEntity
    {
        public RiscoABNT12100()
        {
            Riscos = new List<Risco>();
        }

        public string Descricao { get; set; }
        public List<Risco> Riscos { get; set; }
    }
}
