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
            var apreciacoes = _contexto.ApreciacoesRisco
                                       .Where(o => o.Pessoas.Contains(_contexto.Pessoas.Where(o => o.Id == idUsuario).FirstOrDefault()))
                                       .Select(o => new { o.Id, o.Equipamento, o.DataApreciacao, o.LimiteEspaco, o.LimiteTempo, o.LimiteUso, o.Pessoas, o.IdEquipamento, o.Riscos})
                                       .ToList();

            List<ApreciacaoRisco> listaApreciacoesRisco = new List<ApreciacaoRisco>();

            foreach(var apr in apreciacoes)
            {
                listaApreciacoesRisco.Add(new ApreciacaoRisco
                {
                    Id = apr.Id,
                    Equipamento = apr.Equipamento,
                    LimiteEspaco = apr.LimiteEspaco,
                    LimiteTempo = apr.LimiteTempo,
                    LimiteUso = apr.LimiteUso,
                    DataApreciacao = apr.DataApreciacao,
                    IdEquipamento = apr.IdEquipamento,
                    Riscos  = apr.Riscos,
                    Pessoas = apr.Pessoas
                });
            }

            return listaApreciacoesRisco;
        }
    }
}
