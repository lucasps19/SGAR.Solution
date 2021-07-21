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

        public static implicit operator PessoaDTO(Model.Models.Pessoa pessoa)
        {
            return new PessoaDTO { CPF = pessoa.CPF, Email = pessoa.Email };
        }

    }
}
