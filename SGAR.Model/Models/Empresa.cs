using System.Collections.Generic;

namespace SGAR.Model.Models
{
    public class Empresa : BaseEntity
    {
        public Empresa()
        {
            Pessoas = new List<Pessoa>();
            Equipamentos = new List<Equipamento>();
        }

        public string Nome { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public List<Equipamento> Equipamentos { get; set; }
    }
}
