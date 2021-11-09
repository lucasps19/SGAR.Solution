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

        public void CadastrarEquipamento(Equipamento equipamento)
        {
            _contexto.Equipamentos.Add(equipamento);
            _contexto.SaveChanges();
        }

        public void CadastrarTipoEquipamento(TipoEquipamento tipoEquipamento)
        {
            _contexto.TiposEquipamento.Add(tipoEquipamento);
            _contexto.SaveChanges();
        }

        public ApreciacaoRisco IncluirNovaApreciacaoRisco(ApreciacaoRisco novaApreciacao)
        {
            foreach(var pessoa in novaApreciacao.Pessoas)
            {
                _contexto.Pessoas.Attach(pessoa);
            }
            
            _contexto.ApreciacoesRisco.Add(novaApreciacao);
            _contexto.SaveChanges();

            return novaApreciacao;
        }
    }
}
