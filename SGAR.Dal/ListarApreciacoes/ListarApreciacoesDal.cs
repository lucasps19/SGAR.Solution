using SGAR.Model.Contexto;
using SGAR.Model.Models;
using SGAR.Model.Models.HRN;
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

        public List<FaixaHRN> BuscarFaixasHRN()
        {
            return _contexto.FaixasHRN.ToList();
        }
    }
}
