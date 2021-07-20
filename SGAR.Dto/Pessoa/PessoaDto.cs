using System.Text;
using System.Threading.Tasks;

namespace SGAR.Dto.Pessoa
{
    public class PessoaDTO
    {
        public PessoaDTO()
        {
        }

        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public int Empresa { get; set; }

    }
}
