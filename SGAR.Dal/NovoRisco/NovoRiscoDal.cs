using SGAR.Model.Contexto;
using SGAR.Model.Models;
using SGAR.Model.Models.Categoria_e_Performance_Level;
using SGAR.Model.Models.HRN;
using SGAR.Model.Models.NR12100;
using System.Collections.Generic;
using System.Linq;

namespace SGAR.Dal.NovoRisco
{
    public class NovoRiscoDal
    {
        private readonly Contexto _contexto;

        public NovoRiscoDal(Contexto contexto)
        {
            _contexto = contexto;
        }

        public List<CicloVida> BuscarCicloVida()
        {
            return _contexto.CiclosDeVida.ToList();
        }

        public List<Tarefa> BuscarTarefas(int idCicloVida)
        {
            return _contexto.Tarefas.Where(o => o.IdCicloVida == idCicloVida).ToList();
        }

        public List<TipoGrupoPerigo> BuscarTipoGrupoPerigo()
        {
            return _contexto.TiposGruposPerigo.ToList();
        }

        public List<Dano> BuscarDanos(int idTipoGrupoPerigo)
        {
            return _contexto.Danos.Where(o => o.IdTipoGrupoPerigo == idTipoGrupoPerigo).ToList();
        }

        public List<RiscoABNT12100> BuscarRiscosABNT12100()
        {
            return _contexto.RiscosABNT.ToList();
        }

        public List<GrauPossivelLesao> BuscarGLPHRN()
        {
            return _contexto.GrauPossiveisLesoes.ToList();
        }

        public List<PossibilidadeOcorrencia> BuscarPOHRN()
        {
            return _contexto.PossibilidadesOcorrencia.ToList();
        }

        public List<FrequenciaExposicao> BuscarFEHRN()
        {
            return _contexto.FrequenciasExposicao.ToList();
        }

        public List<NumeroPessoas> BuscarNPHRN()
        {
            return _contexto.NumerosPessoas.ToList();
        }

        public List<FaixaHRN> BuscarFaixasHRN()
        {
            return _contexto.FaixasHRN.ToList();
        }

        public List<SeveridadeFerimento> BuscarSeveridadesFerimento()
        {
            return _contexto.SeveridadesFerimentos.ToList();
        }

        public List<FrequenciaExposicaoPerigo> BuscarFrequenciasExposicaoPerigo()
        {
            return _contexto.FrequenciasExposicaoPerigos.ToList();
        }

        public List<PossibilidadeEvitarPerigo> BuscarPossibilidadesEvitarPerigo()
        {
            return _contexto.PossibilidadesEvitarPerigos.ToList();
        }

        public List<DescricaoCategoria> BuscarDescricoesCategoriaRisco()
        {
            return _contexto.DescricoesCategorias.ToList();
        }

        public List<DescricaoPerformanceLevel> BuscarDescricoesPerformanceLevel()
        {
            return _contexto.DescricoesPerformanceLevel.ToList();
        }

        public HRNAntes InserirHrnAntes(HRNAntes hrnAntes)
        {
            _contexto.FaixasHRN.Attach(hrnAntes.FaixaHRN);
            _contexto.NumerosPessoas.Attach(hrnAntes.NumeroPessoas);
            _contexto.GrauPossiveisLesoes.Attach(hrnAntes.GrauPossivelLesao);
            _contexto.FrequenciasExposicao.Attach(hrnAntes.FrequenciaExposicao);
            _contexto.PossibilidadesOcorrencia.Attach(hrnAntes.PossibilidadeOcorrencia);

            HRNAntes hrn = new HRNAntes()
            {
                IdFaixaHRN = hrnAntes.IdFaixaHRN,
                IdNumeroPessoas = hrnAntes.IdNumeroPessoas,
                IdGrauPossivelLesao = hrnAntes.IdGrauPossivelLesao,
                IdFrequenciaExposicao = hrnAntes.IdFrequenciaExposicao,
                IdPossibilidadeOcorrencia = hrnAntes.IdPossibilidadeOcorrencia
            };

            _contexto.HRNsAntes.Add(hrn);

            _contexto.SaveChanges();

            hrnAntes.Id = hrn.Id;

            return hrnAntes;
        }

        public HRNDepois InserirHrnDepois(HRNDepois hrnDepois)
        {
            HRNDepois hrn = new HRNDepois()
            {
                IdFaixaHRN = hrnDepois.IdFaixaHRN,
                IdNumeroPessoas = hrnDepois.IdNumeroPessoas,
                IdGrauPossivelLesao = hrnDepois.IdGrauPossivelLesao,
                IdFrequenciaExposicao = hrnDepois.IdFrequenciaExposicao,
                IdPossibilidadeOcorrencia = hrnDepois.IdPossibilidadeOcorrencia
            };

            _contexto.HRNsDepois.Add(hrn);

            _contexto.SaveChanges();

            hrnDepois.Id = hrn.Id;

            return hrnDepois;
        }

        public CategoriaRisco InserirCategoriaRisco(CategoriaRisco categoria)
        {
            CategoriaRisco cat = new CategoriaRisco()
            {
                IdDescricaoCategoria = categoria.IdDescricaoCategoria,
                IdSeveridadeFerimento = categoria.IdSeveridadeFerimento,
                IdFrequenciaExposicaoPerigo = categoria.IdFrequenciaExposicaoPerigo,
                IdPossibilidadeEvitarPerigo = categoria.IdPossibilidadeEvitarPerigo
            };

            _contexto.CategoriasRiscos.Add(cat);

            _contexto.SaveChanges();

            categoria.Id = cat.Id;

            return categoria;
        }

        public PerformanceLevelRequerido InserirPerformanceLevelRequerido(PerformanceLevelRequerido performanceLevelRequerido)
        {
            PerformanceLevelRequerido plr = new PerformanceLevelRequerido()
            {
                IdDescricaoPerformanceLevel = performanceLevelRequerido.IdDescricaoPerformanceLevel,
                IdSeveridadeFerimento = performanceLevelRequerido.IdSeveridadeFerimento,
                IdFrequenciaExposicaoPerigo = performanceLevelRequerido.IdFrequenciaExposicaoPerigo,
                IdPossibilidadeEvitarPerigo = performanceLevelRequerido.IdFrequenciaExposicaoPerigo
            };

            _contexto.PerformanceLevelRequeridos.Add(plr);

            _contexto.SaveChanges();

            performanceLevelRequerido.Id = plr.Id;

            return performanceLevelRequerido;
        }

        public Risco InserirNovoRisco(Risco novoRisco)
        {
            Risco risco = new Risco()
            {
                Atividade = novoRisco.Atividade,
                Onde = novoRisco.Onde,
                MedidaProtecaoSugerida = novoRisco.MedidaProtecaoSugerida,
                IdAPreciacaoRisco = novoRisco.IdAPreciacaoRisco,
                IdCicloVida = novoRisco.IdCicloVida,
                IdTarefa = novoRisco.IdTarefa,
                IdTipoGrupoPerigo = novoRisco.IdTipoGrupoPerigo,
                IdRiscoABNT12100 = novoRisco.IdRiscoABNT12100,
                IdDano = novoRisco.IdDano,
                IdHRNAntes = novoRisco.HRNAntes.Id,
                IdCategoriaRisco = novoRisco.CategoriaRisco.Id,
                IdPerformanceLevelRequerido = novoRisco.PerformanceLevelRequerido.Id,
                IdHRNDepois = novoRisco.HRNDepois.Id
            };

            _contexto.Riscos.Add(risco);

            _contexto.SaveChanges();

            novoRisco.Id = risco.Id;

            return novoRisco;
        }
    }
}
