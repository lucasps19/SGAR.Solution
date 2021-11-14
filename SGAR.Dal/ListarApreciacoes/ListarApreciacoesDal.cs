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
            var apreciacoes = _contexto.ApreciacoesRisco.Where(o => o.Pessoas.Contains(_contexto.Pessoas.Where(o => o.Id == idUsuario).FirstOrDefault())).ToList();

            foreach(var apr in apreciacoes)
            {
                apr.Equipamento = _contexto.Equipamentos.Where(o => o.Id == apr.IdEquipamento).FirstOrDefault();
            }            

            return apreciacoes;
        }
    }
}
