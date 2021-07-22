using Microsoft.AspNetCore.Mvc;
//using SGAR.Bll.Login;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        //private readonly LoginBll _loginBll;

        [HttpGet]
        public ActionResult EfetuarLogin()
        {
            return null;
        }

        [HttpGet]
        [Route("/EfetuarLogin")]
        public ActionResult EfetuarLogin(string cpf, string senha)
        {
            if (!string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(senha))
            {
                //var retorno = _loginBll.EfetuarLogin(cpf, senha);

                return RedirectToAction("PaginaInicial");
            }

            return RedirectToAction("Login");
        }
    }
}