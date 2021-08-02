using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.Login;
using SGAR.WebApi.ViewModel.Pessoa;

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
            if (!string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(senha))
            {
                PessoaViewModel retorno = _loginBll.EfetuarLogin(cpf, senha);

                return retorno;
            }

            return BadRequest();
        }
    }
}