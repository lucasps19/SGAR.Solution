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

        public void CadastrarUsuario (PessoaDTO pessoa)
        {
            if (_cadastroUsuarioDal.VerificarCpfJaCadastrado(pessoa.CPF))
            {
                if (_cadastroUsuarioDal.VerificarEmailJaCadastrado(pessoa.Email))
                {
                    _cadastroUsuarioDal.CadastrarUsuario(pessoa);
                }
            }
        }
    }
}