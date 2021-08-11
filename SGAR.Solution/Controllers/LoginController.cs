using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.Login;
using SGAR.WebApi.ViewModel.Pessoa;
using System;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginBll _loginBll;

        public LoginController(LoginBll loginBll)
        {
            _loginBll = loginBll;
        }

        [HttpGet]
        [Route("/EfetuarLogin")]
        public ActionResult<PessoaViewModel> EfetuarLogin(string cpf, string senha)
        {
            PessoaViewModel retorno = new PessoaViewModel();

            if (!string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(senha))
            {
                try
                {
                    retorno = _loginBll.EfetuarLogin(cpf, senha);

                    return retorno;
                }
                catch(Exception ex)
                {
                    return Unauthorized(ex.Message);
                }
            }
            return Unauthorized("Existem campos obrigatórios não preenchidos!");
        }
    }
}