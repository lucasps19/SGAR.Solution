using SGAR.Model.Contexto;
using SGAR.Model.Models;
using SGAR.Model.Models.Categoria_e_Performance_Level;
using SGAR.Model.Models.HRN;
using System.Linq;

namespace SGAR.Dal.EditarRisco
{
    public class EditarRiscoDal
    {
        private readonly Contexto _contexto;

        public EditarRiscoDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Risco BuscarRisco(int idRisco)
        {
            var consulta = _contexto.Riscos.Where(o => o.IdAPreciacaoRisco == idRisco)
                .Select(o => new
                {
                    o.Id,
                    o.IdAPreciacaoRisco,
                    o.IdCicloVida,
                    o.IdTarefa,
                    o.Atividade,
                    o.IdTipoGrupoPerigo,
                    o.IdDano,
                    o.Onde,
                    o.IdRiscoABNT12100,
                    o.MedidaProtecaoSugerida,
                    o.IdHRNAntes,
                    o.IdCategoriaRisco,
                    o.IdPerformanceLevelRequerido,
                    o.IdHRNDepois
                })
                .FirstOrDefault();

            Risco risco = new Risco()
            {
                Id = consulta.Id,
                IdAPreciacaoRisco = consulta.IdAPreciacaoRisco,
                IdCicloVida = consulta.IdCicloVida,
                IdTarefa = consulta.IdTarefa,
                Atividade = consulta.Atividade,
                IdTipoGrupoPerigo = consulta.IdTipoGrupoPerigo,
                IdDano = consulta.IdDano,
                Onde = consulta.Onde,
                IdRiscoABNT12100 = consulta.IdRiscoABNT12100,
                MedidaProtecaoSugerida = consulta.MedidaProtecaoSugerida,
                IdHRNAntes = consulta.IdHRNAntes,
                IdCategoriaRisco = consulta.IdCategoriaRisco,
                IdPerformanceLevelRequerido = consulta.IdPerformanceLevelRequerido,
                IdHRNDepois = consulta.IdHRNDepois
            };

            return risco;
        }

        public HRNAntes BuscarHRNAntes(int idHrnAntes)
        {
            var consulta = _contexto.HRNsAntes.Where(o => o.Id == idHrnAntes)
                .Select(o => new
                {
                    o.Id,
                    o.GrauPossivelLesao,
                    o.FrequenciaExposicao,
                    o.PossibilidadeOcorrencia,
                    o.NumeroPessoas,
                    o.FaixaHRN,
                    o.ValorCalculado
                }).FirstOrDefault();

            HRNAntes hrnAntes = new HRNAntes()
            {
                Id = consulta.Id,
                GrauPossivelLesao = consulta.GrauPossivelLesao,
                FrequenciaExposicao = consulta.FrequenciaExposicao,
                PossibilidadeOcorrencia = consulta.PossibilidadeOcorrencia,
                NumeroPessoas = consulta.NumeroPessoas,
                FaixaHRN = consulta.FaixaHRN,
                ValorCalculado = consulta.ValorCalculado
            };

            return hrnAntes;
        }

        public HRNDepois BuscarHRNDepois(int idHrnDepois)
        {
            var consulta = _contexto.HRNsDepois.Where(o => o.Id == idHrnDepois)
                .Select(o => new
                {
                    o.Id,
                    o.GrauPossivelLesao,
                    o.FrequenciaExposicao,
                    o.PossibilidadeOcorrencia,
                    o.NumeroPessoas,
                    o.FaixaHRN,
                    o.ValorCalculado
                }).FirstOrDefault();

            HRNDepois hrnDepois = new HRNDepois()
            {
                Id = consulta.Id,
                GrauPossivelLesao = consulta.GrauPossivelLesao,
                FrequenciaExposicao = consulta.FrequenciaExposicao,
                PossibilidadeOcorrencia = consulta.PossibilidadeOcorrencia,
                NumeroPessoas = consulta.NumeroPessoas,
                FaixaHRN = consulta.FaixaHRN,
                ValorCalculado = consulta.ValorCalculado
            };

            return hrnDepois;
        }

        public CategoriaRisco BuscarCategoriaRisco(int idCategoria)
        {
            var consulta = _contexto.CategoriasRiscos.Where(o => o.Id == idCategoria)
                .Select(o => new
                {
                    o.Id,
                    o.SeveridadeFerimento,
                    o.FrequenciaExposicaoPerigo,
                    o.PossibilidadeEvitarPerigo,
                    o.DescricaoCategoria
                })
                .FirstOrDefault();

            CategoriaRisco categoria = new CategoriaRisco()
            {
                Id = consulta.Id,
                SeveridadeFerimento = consulta.SeveridadeFerimento,
                FrequenciaExposicaoPerigo = consulta.FrequenciaExposicaoPerigo,
                PossibilidadeEvitarPerigo = consulta.PossibilidadeEvitarPerigo,
                DescricaoCategoria = consulta.DescricaoCategoria
            };

            return categoria;
        }

        public PerformanceLevelRequerido BuscarPerformanceLevelRequerido(int idPlr)
        {
            var consulta = _contexto.PerformanceLevelRequeridos.Where(o => o.Id == idPlr)
                .Select(o => new
                {
                    o.Id,
                    o.SeveridadeFerimento,
                    o.FrequenciaExposicaoPerigo,
                    o.PossibilidadeEvitarPerigo,
                    o.DescricaoPerformanceLevel
                })
                .FirstOrDefault();

            PerformanceLevelRequerido categoria = new PerformanceLevelRequerido()
            {
                Id = consulta.Id,
                SeveridadeFerimento = consulta.SeveridadeFerimento,
                FrequenciaExposicaoPerigo = consulta.FrequenciaExposicaoPerigo,
                PossibilidadeEvitarPerigo = consulta.PossibilidadeEvitarPerigo,
                DescricaoPerformanceLevel = consulta.DescricaoPerformanceLevel
            };

            return categoria;
        }
    }
}
