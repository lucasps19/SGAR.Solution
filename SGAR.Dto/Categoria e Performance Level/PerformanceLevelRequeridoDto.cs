namespace SGAR.Dto.Categoria_e_Performance_Level
{
    public class PerformanceLevelRequeridoDto
    {
        public int Id { get; set; }
        public int IdDescricaoPerformanceLevel { get; set; }
        public DescricaoPerformanceLevelDto DescricaoPerformanceLevel { get; set; }
        public int IdPossibilidadeEvitarPerigo { get; set; }
        public PossibilidadeEvitarPerigoDto PossibilidadeEvitarPerigo { get; set; }
        public int IdFrequenciaExposicaoPerigo { get; set; }
        public FrequenciaExposicaoPerigoDto FrequenciaExposicaoPerigo { get; set; }
        public int IdSeveridadeFerimento { get; set; }
        public SeveridadeFerimentoDto SeveridadeFerimento { get; set; }
    }
}
