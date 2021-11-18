using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.Dto.HRN;
using SGAR.Dto.NR12100;

namespace SGAR.Dto.Apreciacao_de_Risco
{
    public class RiscoDto
    {
        public int Id { get; set; }
        public string Atividade { get; set; }
        public string Onde { get; set; }
        public string MedidaProtecaoSugerida { get; set; }
        public int IdAPreciacaoRisco { get; set; }
        public ApreciacaoRiscoDto ApreciacaoRisco { get; set; }
        public int IdCicloVida { get; set; }
        public CicloVidaDto CicloVida { get; set; }
        public int IdTarefa { get; set; }
        public TarefaDto Tarefa { get; set; }
        public int IdTipoGrupoPerigo { get; set; }
        public TipoGrupoPerigoDto TipoGrupoPerigo { get; set; }
        public int IdDano { get; set; }
        public DanoDto Dano { get; set; }
        public int IdRiscoABNT12100 { get; set; }
        public RiscoABNT12100Dto RiscoABNT12100 { get; set; }
        public int IdHRNAntes { get; set; }
        public HRNAntesDto HRNAntes { get; set; }
        public int IdHRNDepois { get; set; }
        public HRNDepoisDto HRNDepois { get; set; }
        public int IdCategoriaRisco { get; set; }
        public CategoriaRiscoDto CategoriaRisco { get; set; }
        public int IdPerformanceLevelRequerido { get; set; }
        public PerformanceLevelRequeridoDto PerformanceLevelRequerido { get; set; }
    }
}
