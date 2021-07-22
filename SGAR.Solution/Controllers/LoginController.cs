using Microsoft.AspNetCore.Mvc;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
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
                return RedirectToAction("PaginaInicial");
            }

            return RedirectToAction("Login");
        }
    }
}
