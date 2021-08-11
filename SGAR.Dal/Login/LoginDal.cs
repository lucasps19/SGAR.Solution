using SGAR.Model.Contexto;
using SGAR.Model.Models;
using System;
using System.Linq;

namespace SGAR.Dal.Login
{
    public class LoginDal
    {
        private readonly Contexto _contexto;

        public LoginDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Pessoa ObterPessoa(string cpf)
        {
            Pessoa pessoa = _contexto.Pessoas.Where(o => o.CPF == cpf).FirstOrDefault();

            if(pessoa != null)
            {
                return pessoa;
            }
            else
            {
                throw new Exception(message: "Usuário não encontrado!");
            }
        }
    }
}