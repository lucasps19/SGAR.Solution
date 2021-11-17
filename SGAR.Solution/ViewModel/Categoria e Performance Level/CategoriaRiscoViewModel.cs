namespace SGAR.WebApi.ViewModel.Categoria_e_Performance_Level
{
    public class CategoriaRiscoViewModel
    {
        public int Id { get; set; }
        public int IdDescricaoCategoria { get; set; }
        public DescricaoCategoriaViewModel DescricaoCategoria { get; set; }
        public int IdPossibilidadeEvitarPerigo { get; set; }
        public PossibilidadeEvitarPerigoViewModel PossibilidadeEvitarPerigo { get; set; }
        public int IdFrequenciaExposicaoPerigo { get; set; }
        public FrequenciaExposicaoPerigoViewModel FrequenciaExposicaoPerigo { get; set; }
        public int IdSeveridadeFerimento { get; set; }
        public SeveridadeFerimentoViewModel SeveridadeFerimento { get; set; }
    }
}
