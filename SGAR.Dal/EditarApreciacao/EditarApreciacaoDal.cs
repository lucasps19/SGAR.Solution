using SGAR.Model.Contexto;
using SGAR.Model.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
            var apr = _contexto.ApreciacoesRisco.Where(o => o.Id == idApreciacaoRisco)
                                .Select(o => new { o.Id, o.Equipamento, o.DataApreciacao, o.LimiteEspaco, o.LimiteTempo, o.LimiteUso, o.Pessoas, o.IdEquipamento, o.Riscos })
                                .FirstOrDefault();

            ApreciacaoRisco apreciacaoRisco = new ApreciacaoRisco()
            {
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

        public ApreciacaoRisco AtualizarApreciacaoRisco(ApreciacaoRisco apreciacaoRisco)
        {
            apreciacaoRisco.IdEquipamento = apreciacaoRisco.Equipamento.Id;

            _contexto.ApreciacoesRisco.AddOrUpdate(apreciacaoRisco);
            _contexto.SaveChanges();
            
            return apreciacaoRisco;
        }

        public List<Risco> BuscarListaRiscos(int idApreciacao)
        {
            List<Risco> listaRiscos = new List<Risco>();

            var lista = _contexto.Riscos.Where(o => o.IdAPreciacaoRisco == idApreciacao)
                .Select(o => new { o.Id, 
                                   o.ApreciacaoRisco, 
                                   o.CicloVida, 
                                   o.Tarefa, 
                                   o.Atividade, 
                                   o.TipoGrupoPerigo, 
                                   o.Dano, 
                                   o.Onde, 
                                   o.RiscoABNT12100, 
                                   o.MedidaProtecaoSugerida,
                                   o.HRNAntes, 
                                   o.CategoriaRisco, 
                                   o.PerformanceLevelRequerido, 
                                   o.HRNDepois})
                .ToList();

            foreach(var risco in lista)
            {
                listaRiscos.Add(new Risco()
                {
                    Id = risco.Id,
                    ApreciacaoRisco = risco.ApreciacaoRisco,
                    IdAPreciacaoRisco = risco.ApreciacaoRisco.Id,
                    CicloVida = risco.CicloVida,
                    IdCicloVida = risco.CicloVida.Id,
                    Tarefa = risco.Tarefa,
                    IdTarefa = risco.Tarefa.Id,
                    Atividade = risco.Atividade,
                    TipoGrupoPerigo = risco.TipoGrupoPerigo,
                    IdTipoGrupoPerigo = risco.TipoGrupoPerigo.Id,
                    Dano = risco.Dano,
                    IdDano = risco.Dano.Id,
                    Onde = risco.Onde,
                    RiscoABNT12100 = risco.RiscoABNT12100,
                    IdRiscoABNT12100 = risco.RiscoABNT12100.Id,
                    MedidaProtecaoSugerida = risco.MedidaProtecaoSugerida,
                    HRNAntes = risco.HRNAntes,
                    IdHRNAntes = risco.HRNAntes.Id,
                    CategoriaRisco = risco.CategoriaRisco,
                    IdCategoriaRisco = risco.CategoriaRisco.Id,
                    PerformanceLevelRequerido = risco.PerformanceLevelRequerido,
                    IdPerformanceLevelRequerido = risco.PerformanceLevelRequerido.Id,
                    HRNDepois = risco.HRNDepois,
                    IdHRNDepois = risco.HRNDepois.Id
                });
            }

            return listaRiscos;
        }
    }
}
