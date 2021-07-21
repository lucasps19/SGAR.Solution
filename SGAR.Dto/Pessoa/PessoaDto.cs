namespace SGAR.Dto.Pessoa
{
    public class PessoaDTO
    {
        public PessoaDTO()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public int Empresa { get; set; }

        public static implicit operator PessoaDTO(Model.Models.Pessoa pessoa)
        {
            return new PessoaDTO
            {
                Id = pessoa.Id,
                Nome = pessoa.Nome,
                Email = pessoa.Email,
                CPF = pessoa.CPF,
                Senha = pessoa.Senha,
                Empresa = pessoa.IdEmpresa
            };
        }

    }
}
