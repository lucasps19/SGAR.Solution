using SGAR.Model.Models.NR12100;

namespace SGAR.Dto.NR12100
{
    public class DanoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdTipoGrupoPerigo { get; set; }
        public TipoGrupoPerigo TipoGrupoPerigo { get; set; }
    }
}
