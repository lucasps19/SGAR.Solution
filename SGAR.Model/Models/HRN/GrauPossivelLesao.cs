using System.Collections.Generic;

namespace SGAR.Model.Models.HRN
{
    public class GrauPossivelLesao : BaseEntity
    {
        public GrauPossivelLesao()
        {
            HRNsAntes = new List<HRNAntes>();
            HRNsDepois = new List<HRNDepois>();
        }

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public List<HRNAntes> HRNsAntes { get; set; }
        public List<HRNDepois> HRNsDepois { get; set; }
    }
}
