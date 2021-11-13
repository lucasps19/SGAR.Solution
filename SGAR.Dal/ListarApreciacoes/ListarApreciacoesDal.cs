using SGAR.Model.Contexto;
using SGAR.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace SGAR.Dal.ListarApreciacoes
{
    public class ListarApreciacoesDal
    {
        private readonly Contexto _contexto;

        public ListarApreciacoesDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<ApreciacaoRisco> BuscarApreciacoesRiscoDoUsuario(int idUsuario)
        {
            return _contexto.ApreciacoesRisco.Where(o => o.Pessoas.Contains(_contexto.Pessoas.Where(o => o.Id == idUsuario).FirstOrDefault())).ToList();
        }
    }
}
