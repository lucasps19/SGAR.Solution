using AutoMapper;
using SGAR.Dal.Login;
using SGAR.Dto.Pessoa;
using SGAR.Model.Models;
using System;

namespace SGAR.Bll.Login
{
    public class LoginBll
    {
        private readonly LoginDal _loginDal;
        private readonly IMapper _mapper;

        public LoginBll(LoginDal loginDal, IMapper mapper)
        {
            _loginDal = loginDal;
            _mapper = mapper;
        }

        public PessoaDTO EfetuarLogin(string cpf, string senha)
        {
            PessoaDTO pessoa = _mapper.Map<Pessoa, PessoaDTO>(_loginDal.ObterPessoa(cpf));

            string senhaUsuario = pessoa.Senha;

            if (senhaUsuario == senha)
            {
                return pessoa;
            }
            else
            {
                throw new Exception(message: "Usuário ou Senha incorreto!");
            }
        }
    }
}