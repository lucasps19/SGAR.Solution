using System.Collections.Generic;

namespace SGAR.Model.Models
{
    public class TipoEquipamento : BaseEntity
    {
        public TipoEquipamento()
        {
            Equipamentos = new List<Equipamento>();
        }

        public string Descricao { get; set; }
        public List<Equipamento> Equipamentos { get; set; }
    }
}
