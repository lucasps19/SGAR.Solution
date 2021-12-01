namespace SGAR.Dto.Apreciacao_de_Risco
{
    public class TabelaRiscosDto
    {
        public int Id { get; set; }
        public string CicloVida { get; set; }
        public string Tarefa { get; set; }
        public string Atividade { get; set; }
        public string TipoGrupoPerigo { get; set; }
        public string Dano { get; set; }
        public string Onde { get; set; }
        public string RiscoABNT12100 { get; set; }
        public string MedidaProtecaoSugerida { get; set; }
        public decimal ValorCalculadoHRNAntes { get; set; }
        public string FaixaHRNAntes { get; set; }
        public string Categoria { get; set; }
        public string PerformanceLevelRequerido { get; set; }
        public decimal ValorCalculadoHRNDepois { get; set; }
        public string FaixaHRNDepois { get; set; }
    }
}
