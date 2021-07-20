using System.Collections.Generic;

namespace SGAR.Model.Models.HRN
{
    public class FaixaHRN : BaseEntity
    {
        public FaixaHRN()
        {
            HRNsAntes = new List<HRNAntes>();
            HRNsDepois = new List<HRNDepois>();
        }

        public string Faixa { get; set; }
        public string Descricao { get; set; }
        public List<HRNAntes> HRNsAntes { get; set; }
        public List<HRNDepois> HRNsDepois { get; set; }
    }
}
