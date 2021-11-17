namespace SGAR.WebApi.ViewModel.HRN
{
    public class HRNDepoisViewModel
    {
        public int Id { get; set; }
        public int ValorCalculado { get; set; }
        public int IdFaixaHRN { get; set; }
        public FaixaHRNViewModel FaixaHRN { get; set; }
        public int IdPossibilidadeOcorrencia { get; set; }
        public PossibilidadeOcorrenciaViewModel PossibilidadeOcorrencia { get; set; }
        public int IdFrequenciaExposicao { get; set; }
        public FrequenciaExposicaoViewModel FrequenciaExposicao { get; set; }
        public int IdNumeroPessoas { get; set; }
        public NumeroPessoasViewModel NumeroPessoas { get; set; }
        public int IdGrauPossivelLesao { get; set; }
        public GrauPossivelLesaoViewModel GrauPossivelLesao { get; set; }
    }
}
