using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.Login;
using SGAR.Dto.Pessoa;
using SGAR.WebApi.ViewModel.Pessoa;
using System;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginBll _loginBll;
        private readonly IMapper _mapper;

        public LoginController(LoginBll loginBll, IMapper mapper)
        {
            _loginBll = loginBll;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/EfetuarLogin")]
        public ActionResult<PessoaViewModel> EfetuarLogin(string cpf, string senha)
        {
            if (!string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(senha))
            {
                try
                {
                    PessoaViewModel retorno = _mapper.Map<PessoaDTO, PessoaViewModel>(_loginBll.EfetuarLogin(cpf, senha));

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