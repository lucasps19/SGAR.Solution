using System.Collections.Generic;

namespace SGAR.Model.Models.Categoria_e_Performance_Level
{
    public class PerformanceLevelRequerido : BaseEntity
    {
        public PerformanceLevelRequerido()
        {
            Riscos = new List<Risco>();
        }

        public int IdDescricaoPerformanceLevel { get; set; }
        public DescricaoPerformanceLevel DescricaoPerformanceLevel { get; set; }
        public int IdPossibilidadeEvitarPerigo { get; set; }
        public PossibilidadeEvitarPerigo PossibilidadeEvitarPerigo { get; set; }
        public int IdFrequenciaExposicaoPerigo { get; set; }
        public FrequenciaExposicaoPerigo FrequenciaExposicaoPerigo { get; set; }
        public int IdSeveridadeFerimento { get; set; }
        public SeveridadeFerimento SeveridadeFerimento { get; set; }
        public List<Risco> Riscos { get; set; }
    }
}
