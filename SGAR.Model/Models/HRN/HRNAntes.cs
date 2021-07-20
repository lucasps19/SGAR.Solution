using System.Collections.Generic;

namespace SGAR.Model.Models.HRN
{
    public class HRNAntes : BaseEntity
    {
        public HRNAntes()
        {
            Riscos = new List<Risco>();
        }

        public int ValorCalculado { get; set; }
        public int IdFaixaHRN { get; set; }
        public FaixaHRN FaixaHRN { get; set; }
        public int IdPossibilidadeOcorrencia { get; set; }
        public PossibilidadeOcorrencia PossibilidadeOcorrencia { get; set; }
        public int IdFrequenciaExposicao { get; set; }
        public FrequenciaExposicao FrequenciaExposicao { get; set; }
        public int IdNumeroPessoas { get; set; }
        public NumeroPessoas NumeroPessoas { get; set; }
        public int IdGrauPossivelLesao { get; set; }
        public GrauPossivelLesao GrauPossivelLesao { get; set; }
        public List<Risco> Riscos { get; set; }
    }
}
