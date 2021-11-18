using SGAR.WebApi.ViewModel.Categoria_e_Performance_Level;
using SGAR.WebApi.ViewModel.HRN;
using SGAR.WebApi.ViewModel.NR12100;

namespace SGAR.WebApi.ViewModel.ApreciacaoRisco
{
    public class RiscoViewModel
    {
        public int Id { get; set; }
        public string Atividade { get; set; }
        public string Onde { get; set; }
        public string MedidaProtecaoSugerida { get; set; }
        public int IdAPreciacaoRisco { get; set; }
        public ApreciacaoRiscoViewModel ApreciacaoRisco { get; set; }
        public int IdCicloVida { get; set; }
        public CicloVidaViewModel CicloVida { get; set; }
        public int IdTarefa { get; set; }
        public TarefaViewModel Tarefa { get; set; }
        public int IdTipoGrupoPerigo { get; set; }
        public TipoGrupoPerigoViewModel TipoGrupoPerigo { get; set; }
        public int IdDano { get; set; }
        public DanoViewModel Dano { get; set; }
        public int IdRiscoABNT12100 { get; set; }
        public RiscoABNT12100ViewModel RiscoABNT12100 { get; set; }
        public int IdHRNAntes { get; set; }
        public HRNAntesViewModel HRNAntes { get; set; }
        public int IdHRNDepois { get; set; }
        public HRNDepoisViewModel HRNDepois { get; set; }
        public int IdCategoriaRisco { get; set; }
        public CategoriaRiscoViewModel CategoriaRisco { get; set; }
        public int IdPerformanceLevelRequerido { get; set; }
        public PerformanceLevelRequeridoViewModel PerformanceLevelRequerido { get; set; }
    }
}
