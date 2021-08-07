using SGAR.Dto.Pessoa;

namespace SGAR.WebApi.ViewModel.Pessoa
{
    public class PessoaViewModel
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public int? Empresa { get; set; }

        public static implicit operator PessoaViewModel(PessoaDTO pessoa)
        {
            return new PessoaViewModel
            {
                Id = pessoa.Id,
                Nome = pessoa.Nome,
                Email = pessoa.Email,
                CPF = pessoa.CPF,
                Senha = pessoa.Senha,
                Empresa = pessoa.Empresa
            };
        }
    }
}
