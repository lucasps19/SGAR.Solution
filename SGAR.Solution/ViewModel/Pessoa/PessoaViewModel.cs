using SGAR.Dto.Pessoa;

namespace SGAR.WebApi.ViewModel.Pessoa
{
    public class PessoaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public int IdEmpresa { get; set; }
    }
}
