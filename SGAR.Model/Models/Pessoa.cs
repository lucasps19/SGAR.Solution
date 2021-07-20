using System.Collections.Generic;

namespace SGAR.Model.Models
{
    public class Pessoa : BaseEntity
    {
        public Pessoa()
        {
            ApreciacoesRiscos = new List<ApreciacaoRisco>();
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
        public List<ApreciacaoRisco> ApreciacoesRiscos { get; set; }
    }
}
