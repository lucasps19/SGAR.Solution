
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.CadastroUsuarios;
using SGAR.Dto.Empresa;
using SGAR.Dto.Pessoa;
using SGAR.WebApi.ViewModel.Empresa;
using SGAR.WebApi.ViewModel.Pessoa;
using System;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroUsuarioController : ControllerBase
    {
        private readonly CadastroUsuarioBll _cadastroUsuarioBll;
        private readonly IMapper _mapper;

        public CadastroUsuarioController(CadastroUsuarioBll cadastroUsuarioBll, IMapper mapper)
        {
            _cadastroUsuarioBll = cadastroUsuarioBll;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("/CadastrarUsuario")]
        public ActionResult CadastrarUsuario(PessoaViewModel pessoa)
        {
            if (!string.IsNullOrEmpty(pessoa.Nome)  && !string.IsNullOrEmpty(pessoa.Email) && !string.IsNullOrEmpty(pessoa.Email) && !string.IsNullOrEmpty(pessoa.Senha) && pessoa.IdEmpresa != 0)
            {
                PessoaDTO dados = new()
                {
                    Nome = pessoa.Nome.ToUpper(),
                    Email = pessoa.Email,
                    CPF = pessoa.CPF,
                    Senha = pessoa.Senha,
                    IdEmpresa = pessoa.IdEmpresa
                };

                try
                {
                    _cadastroUsuarioBll.CadastrarUsuario(dados);

                    return Ok();
                }
                catch(Exception ex)
                {
                    return Unauthorized(ex.Message);
                }
            }
            return Unauthorized();
        }

        [HttpGet]
        [Route("/BuscarEmpresasCadastradas")]
        public ActionResult<EmpresaViewModel> BuscarEmpresasCadastradas()
        {
            EmpresaDto empresa = new(){
                Id = 1,
                Nome = "TESTE"
            };

            return _mapper.Map<EmpresaDto, EmpresaViewModel>(empresa);
        }
    }
}