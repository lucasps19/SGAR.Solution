using SGAR.Model.Contexto;
using SGAR.Model.Models;
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

        //public int BuscaProximoIdPessoa()
        //{
        //    return null;
        //}
    }
}
