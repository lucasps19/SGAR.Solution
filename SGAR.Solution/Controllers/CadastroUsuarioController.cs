using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.CadastroUsuarios;
using SGAR.Dto.Pessoa;
using SGAR.WebApi.ViewModel.Pessoa;
using System;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroUsuarioController : ControllerBase
    {
        private readonly CadastroUsuarioBll _cadastroUsuarioBll;

        public CadastroUsuarioController(CadastroUsuarioBll cadastroUsuarioBll)
        {
            _cadastroUsuarioBll = cadastroUsuarioBll;
        }

        [HttpPost]
        [Route("/CadastrarUsuario")]
        public ActionResult CadastrarUsuario(string nome, string email, string cpf, string senha, int idEmpresa = 0)
        {
            if (!string.IsNullOrEmpty(nome) || !string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(cpf) || !string.IsNullOrEmpty(senha) || idEmpresa != 0)
            {
                try
                {
                    _cadastroUsuarioBll.CadastrarUsuario(nome, email, cpf, senha, idEmpresa);

                    return Ok("Cadastro efetuado com sucesso");
                }
                catch(Exception ex)
                {
                    return Ok(ex.Message);
                }
            }
            return Ok("Existem campos obrigatórios não preenchidos!");
        }
    }
}
