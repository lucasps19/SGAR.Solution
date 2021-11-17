namespace SGAR.Dto.HRN
{
    public class HRNDepoisDto
    {
        public int Id { get; set; }
        public int ValorCalculado { get; set; }
        public int IdFaixaHRN { get; set; }
        public FaixaHRNDto FaixaHRN { get; set; }
        public int IdPossibilidadeOcorrencia { get; set; }
        public PossibilidadeOcorrenciaDto PossibilidadeOcorrencia { get; set; }
        public int IdFrequenciaExposicao { get; set; }
        public FrequenciaExposicaoDto FrequenciaExposicao { get; set; }
        public int IdNumeroPessoas { get; set; }
        public NumeroPessoasDto NumeroPessoas { get; set; }
        public int IdGrauPossivelLesao { get; set; }
        public GrauPossivelLesaoDto GrauPossivelLesao { get; set; }
    }
}
