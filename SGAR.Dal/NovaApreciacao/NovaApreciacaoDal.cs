using SGAR.Model.Contexto;
using SGAR.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace SGAR.Dal.NovaApreciacao
{
    public class NovaApreciacaoDal
    {
        private readonly Contexto _contexto;

        public NovaApreciacaoDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<Equipamento> BuscarEquipamentos()
        {
            return _contexto.Equipamentos.ToList();
        }
    }
}
