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

        public List<Pessoa> BuscarPessoasPorEmpresa(int idEmpresa)
        {
            return _contexto.Pessoas.Where(o => o.IdEmpresa == idEmpresa).ToList();
        }

        public List<TipoEquipamento> BuscarTiposEquipamentos()
        {
            return _contexto.TiposEquipamento.ToList();
        }
    }
}
