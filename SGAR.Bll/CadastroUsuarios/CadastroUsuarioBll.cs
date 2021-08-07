using SGAR.Dal.CadastroUsuarios;
using SGAR.Dto.Pessoa;
using SGAR.Model.Models;
using System;

namespace SGAR.Bll.CadastroUsuarios
{
    public class CadastroUsuarioBll
    {
        private readonly CadastroUsuarioDal _cadastroUsuarioDal;

        public CadastroUsuarioBll(CadastroUsuarioDal cadastroUsuarioDal)
        {
            _cadastroUsuarioDal = cadastroUsuarioDal;
        }

        public void CadastrarUsuario (string nome, string email, string cpf, string senha, int idEmpresa)
        {
            PessoaDTO pessoa = new PessoaDTO();

            pessoa.Nome = nome;
            pessoa.Email = email;
            pessoa.CPF = cpf;
            pessoa.Senha = senha;
            pessoa.Empresa = idEmpresa;

            pessoa.Id = 3;

            _cadastroUsuarioDal.CadastrarUsuario(pessoa);
        }
    }
}
