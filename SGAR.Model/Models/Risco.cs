

using SGAR.Model.Models.Categoria_e_Performance_Level;
using SGAR.Model.Models.HRN;
using SGAR.Model.Models.NR12100;

namespace SGAR.Model.Models
{
    public class Risco : BaseEntity
    {
        public string Atividade { get; set; }
        public string Onde { get; set; }
        public string MedidaProtecaoSugerida { get; set; }
        public int IdAPreciacaoRisco { get; set; }
        public ApreciacaoRisco ApreciacaoRisco { get; set; }
        public int IdCicloVida { get; set; }
        public CicloVida CicloVida { get; set; }
        public int IdTarefa { get; set; }
        public Tarefa Tarefa { get; set; }
        public int IdTipoGrupoPerigo { get; set; }
        public TipoGrupoPerigo TipoGrupoPerigo { get; set; }
        public int IdDano { get; set; }
        public Dano Dano { get; set; }
        public int IdRiscoABNT12100 { get; set; }
        public RiscoABNT12100 RiscoABNT12100 { get; set; }
        public int IdHRNAntes { get; set; }
        public HRNAntes HRNAntes { get; set; }
        public int IdHRNDepois { get; set; }
        public HRNDepois HRNDepois { get; set; }
        public int IdCategoriaRisco { get; set; }
        public CategoriaRisco CategoriaRisco { get; set; }
        public int IdPerformanceLevelRequerido { get; set; }
        public PerformanceLevelRequerido PerformanceLevelRequerido { get; set; }
    }
}
