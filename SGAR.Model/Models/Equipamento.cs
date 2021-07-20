using System.Collections.Generic;

namespace SGAR.Model.Models
{
    public class Equipamento : BaseEntity
    {
        public Equipamento()
        {
            ApreciacoesRisco = new List<ApreciacaoRisco>();
        }

        public string Nome { get; set; }
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
        public int IdTipoEquipamento { get; set; }
        public TipoEquipamento TipoEquipamento { get; set; }
        public List<ApreciacaoRisco> ApreciacoesRisco { get; set; }
    }
}
