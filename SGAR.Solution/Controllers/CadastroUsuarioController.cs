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
        public ActionResult CadastrarUsuario(PessoaViewModel pessoa)
        {
            if (!string.IsNullOrEmpty(pessoa.Nome)  && !string.IsNullOrEmpty(pessoa.Email) && !string.IsNullOrEmpty(pessoa.Email) && !string.IsNullOrEmpty(pessoa.Senha) && pessoa.Empresa != 0)
            {
                PessoaDTO dados = new()
                {
                    Nome = pessoa.Nome.ToUpper(),
                    Email = pessoa.Email,
                    CPF = pessoa.CPF,
                    Senha = pessoa.Senha,
                    Empresa = pessoa.Empresa
                };

                try
                {
                    _cadastroUsuarioBll.CadastrarUsuario(dados);

                    return Ok("Cadastro efetuado com sucesso");
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