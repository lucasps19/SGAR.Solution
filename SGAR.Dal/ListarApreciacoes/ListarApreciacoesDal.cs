using SGAR.Model.Contexto;
using SGAR.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAR.Dal.ListarApreciacoes
{
    public class ListarApreciacoesDal
    {
        private readonly Contexto _contexto;

        public ListarApreciacoesDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<TipoEquipamento> BuscarTiposEquipamentos()
        {
            List<TipoEquipamento> tiposEquipamentos = _contexto.TiposEquipamento.ToList();

            return tiposEquipamentos;
        }
    }
}
