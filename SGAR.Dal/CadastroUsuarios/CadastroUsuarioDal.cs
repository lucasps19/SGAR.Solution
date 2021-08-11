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
            var resposta = _contexto.Pessoas.Where(o => o.Email == email).FirstOrDefault();

            if (string.IsNullOrEmpty(resposta.ToString()))
            {
                return true;
            }
            else
            {
                throw new Exception(message: "Esse email ja esta cadastrado, favor utilizar outro email");
            }
        }
    }
}