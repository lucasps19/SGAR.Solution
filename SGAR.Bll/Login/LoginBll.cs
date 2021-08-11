using SGAR.Dal.Login;
using SGAR.Dto.Pessoa;
using System;

namespace SGAR.Bll.Login
{
    public class LoginBll
    {
        private readonly LoginDal _loginDal;

        public LoginBll(LoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public PessoaDTO EfetuarLogin(string cpf, string senha)
        {
            PessoaDTO pessoa = _loginDal.ObterPessoa(cpf);

            string senhaUsuario = pessoa.Senha;

            if (senhaUsuario == senha)
            {
                return pessoa;
            }
            else
            {
                throw new Exception(message: "Usuário ou Senha incorreto!");
            }
        }
    }
}