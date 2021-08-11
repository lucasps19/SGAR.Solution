using SGAR.Model.Contexto;
using SGAR.Model.Models;
using System;
using System.Linq;

namespace SGAR.Dal.CadastroUsuarios
{
    public class CadastroUsuarioDal
    {
        private readonly Contexto _contexto;

        public CadastroUsuarioDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void CadastrarUsuario(Pessoa pessoa)
        {
            _contexto.Pessoas.Add(pessoa);

            _contexto.SaveChanges();
        }

        public bool VerificarEmailJaCadastrado(string email)
        {
            var resposta = _contexto.Pessoas.Where(o => o.Email == email).Count();

            if (resposta > 0)
            {
                throw new Exception(message: "O email " + email + " ja esta cadastrado, favor utilizar outro email!");
            }
            else
            {
                return true;
            }
        }

        public bool VerificarCpfJaCadastrado(string cpf)
        {
            var resposta = _contexto.Pessoas.Where(o => o.CPF == cpf).Count();

            if (resposta > 0)
            {
                throw new Exception(message: "O CPF " + cpf + " ja esta cadastrado, favor utilizar outro CPF!");
            }
            else
            {
                return true;
            }
        }
    }
}