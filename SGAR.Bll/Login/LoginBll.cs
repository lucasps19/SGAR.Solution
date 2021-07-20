using SGAR.Dal.Login;
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

        //public string EfetuarLogin(string cpf, string senha)
        //{
            
        //}
    }
}
