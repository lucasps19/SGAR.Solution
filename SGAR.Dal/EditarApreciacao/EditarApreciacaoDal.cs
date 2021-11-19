using SGAR.Model.Contexto;
using SGAR.Model.Models;
using System.Linq;

namespace SGAR.Dal.EditarApreciacao
{
    public class EditarApreciacaoDal
    {
        private readonly Contexto _contexto;

        public EditarApreciacaoDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public ApreciacaoRisco BuscarApreciacaoRisco(int idApreciacaoRisco)
        {
            var apr =  _contexto.ApreciacoesRisco.Where(o => o.Id == idApreciacaoRisco)
                                .Select(o => new { o.Id, o.Equipamento, o.DataApreciacao, o.LimiteEspaco, o.LimiteTempo, o.LimiteUso, o.Pessoas, o.IdEquipamento, o.Riscos })
                                .FirstOrDefault();

            ApreciacaoRisco apreciacaoRisco = new ApreciacaoRisco(){
                Id = apr.Id,
                Equipamento = apr.Equipamento,
                DataApreciacao = apr.DataApreciacao,
                LimiteEspaco = apr.LimiteEspaco,
                LimiteTempo = apr.LimiteTempo,
                LimiteUso = apr.LimiteUso,
                Pessoas = apr.Pessoas,
                IdEquipamento = apr.IdEquipamento,
                Riscos = apr.Riscos
            };

            return apreciacaoRisco;
        }
    }
}
