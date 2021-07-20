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

        public string EfetuarLogin(string cpf, string senha)
        {
            PessoaDTO pessoa = _loginDal.ObterPessoa(cpf);

            string senhaUsuario = pessoa.Senha;

            try
            {
                if (senhaUsuario == senha)
                {
                    return "Sucesso";
                }
                else
                {
                    throw new Exception(message: "Usuário ou Senha incorreto!");
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
