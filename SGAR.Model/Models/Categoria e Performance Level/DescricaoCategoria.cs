using System.Collections.Generic;

namespace SGAR.Model.Models.Categoria_e_Performance_Level
{
    public class DescricaoCategoria : BaseEntity
    {
        public DescricaoCategoria()
        {
            CategoriasRisco = new List<CategoriaRisco>();
            PerformancesLevelRequeridos = new List<PerformanceLevelRequerido>();
        }
        public string Descricao { get; set; }
        public List<CategoriaRisco> CategoriasRisco { get; set; }
        public List<PerformanceLevelRequerido> PerformancesLevelRequeridos { get; set; }
    }
}
