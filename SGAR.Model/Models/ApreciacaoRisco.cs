using System;
using System.Collections.Generic;

namespace SGAR.Model.Models
{
    public class ApreciacaoRisco : BaseEntity
    {
        public ApreciacaoRisco()
        {
            Pessoas = new List<Pessoa>();
            Riscos = new List<Risco>();
        }
        public DateTime DataApreciacao { get; set; }
        public string LimiteUso { get; set; }
        public string LimiteEspaco { get; set; }
        public string LimiteTempo { get; set; }
        public int IdEquipamento { get; set; }
        public Equipamento Equipamento { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public List<Risco> Riscos { get; set; }
    }
}
