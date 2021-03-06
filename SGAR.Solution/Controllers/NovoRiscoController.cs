using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.EditarApreciacao;
using SGAR.Bll.NovoRisco;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.Dto.HRN;
using SGAR.Dto.NR12100;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;
using SGAR.WebApi.ViewModel.Categoria_e_Performance_Level;
using SGAR.WebApi.ViewModel.HRN;
using SGAR.WebApi.ViewModel.NR12100;
using System;
using System.Collections.Generic;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NovoRiscoController : ControllerBase
    {
        private readonly NovoRiscoBll _novoRiscoBll;
        private readonly EditarApreciacaoBll _editarApreciacaoBll;
        private readonly IMapper _mapper;

        public NovoRiscoController(NovoRiscoBll novoRiscoBll, EditarApreciacaoBll editarApreciacaoBll, IMapper mapper)
        {
            _novoRiscoBll = novoRiscoBll;
            _editarApreciacaoBll = editarApreciacaoBll;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/BuscarCicloVida")]
        public ActionResult<List<CicloVidaViewModel>> BuscarCicloVida()
        {
            try
            {
                return _mapper.Map<List<CicloVidaDto>, List<CicloVidaViewModel>>(_novoRiscoBll.BuscarCicloVida());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarTarefas")]
        public ActionResult<List<TarefaViewModel>> BuscarTarefas(int idCiclVida)
        {
            try
            {
                return _mapper.Map<List<TarefaDto>, List<TarefaViewModel>>(_novoRiscoBll.BuscarTarefas(idCiclVida));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarTipoGrupoPerigo")]
        public ActionResult<List<TipoGrupoPerigoViewModel>> BuscarTipoGrupoPerigo()
        {
            try
            {
                return _mapper.Map<List<TipoGrupoPerigoDto>, List<TipoGrupoPerigoViewModel>>(_novoRiscoBll.BuscarTipoGrupoPerigo());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarDano")]
        public ActionResult<List<DanoViewModel>> BuscarDanos(int idTipoGrupoPerigo)
        {
            try
            {
                return _mapper.Map<List<DanoDto>, List<DanoViewModel>>(_novoRiscoBll.BuscarDanos(idTipoGrupoPerigo));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarRiscosABNT12100")]
        public ActionResult<List<RiscoABNT12100ViewModel>> BuscarRiscosABNT12100()
        {
            try
            {
                return _mapper.Map<List<RiscoABNT12100Dto>, List<RiscoABNT12100ViewModel>>(_novoRiscoBll.BuscarRiscosABNT12100());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarGLP-HRN")]
        public ActionResult<List<GrauPossivelLesaoViewModel>> BuscarGLPHRN()
        {
            try
            {
                return _mapper.Map<List<GrauPossivelLesaoDto>, List<GrauPossivelLesaoViewModel>>(_novoRiscoBll.BuscarGLPHRN());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarPO-HRN")]
        public ActionResult<List<PossibilidadeOcorrenciaViewModel>> BuscarPOHRN()
        {
            try
            {
                return _mapper.Map<List<PossibilidadeOcorrenciaDto>, List<PossibilidadeOcorrenciaViewModel>>(_novoRiscoBll.BuscarPOHRN());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarFE-HRN")]
        public ActionResult<List<FrequenciaExposicaoViewModel>> BuscarFEHRN()
        {
            try
            {
                return _mapper.Map<List<FrequenciaExposicaoDto>, List<FrequenciaExposicaoViewModel>>(_novoRiscoBll.BuscarFEHRN());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarNP-HRN")]
        public ActionResult<List<NumeroPessoasViewModel>> BuscarNPHRN()
        {
            try
            {
                return _mapper.Map<List<NumeroPessoasDto>, List<NumeroPessoasViewModel>>(_novoRiscoBll.BuscarNPHRN());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost]
        [Route("/CalcularHrnAntes")]
        public ActionResult<HRNAntesViewModel> CalcularHrnAntes(HRNAntesViewModel hrnAntes)
        {
            try
            {
                return _mapper.Map<HRNAntesDto, HRNAntesViewModel>(_novoRiscoBll.CalcularHrnAntes(_mapper.Map<HRNAntesViewModel, HRNAntesDto>(hrnAntes)));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost]
        [Route("/CalcularHrnDepois")]
        public ActionResult<HRNDepoisViewModel> CalcularHrnDepois(HRNDepoisViewModel hrnDepois)
        {
            try
            {
                return _mapper.Map<HRNDepoisDto, HRNDepoisViewModel>(_novoRiscoBll.CalcularHrnDepois(_mapper.Map<HRNDepoisViewModel, HRNDepoisDto>(hrnDepois)));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarSeveridadesFerimento")]
        public ActionResult<List<SeveridadeFerimentoViewModel>> BuscarSeveridadesFerimento()
        {
            try
            {
                return _mapper.Map<List<SeveridadeFerimentoDto>, List<SeveridadeFerimentoViewModel>>(_novoRiscoBll.BuscarSeveridadesFerimento());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarFrequenciasExposicaoPerigo")]
        public ActionResult<List<FrequenciaExposicaoPerigoViewModel>> BuscarFrequenciasExposicaoPerigo()
        {
            try
            {
                return _mapper.Map<List<FrequenciaExposicaoPerigoDto>, List<FrequenciaExposicaoPerigoViewModel>>(_novoRiscoBll.BuscarFrequenciasExposicaoPerigo());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarPossibilidadesEvitarPerigo")]
        public ActionResult<List<PossibilidadeEvitarPerigoViewModel>> BuscarPossibilidadesEvitarPerigo()
        {
            try
            {
                return _mapper.Map<List<PossibilidadeEvitarPerigoDto>, List<PossibilidadeEvitarPerigoViewModel>>(_novoRiscoBll.BuscarPossibilidadesEvitarPerigo());
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost]
        [Route("/CalcularCategoriaPLr")]
        public ActionResult<CategoriaPerformanceLevelRequeridoViewModel> CalcularCategoriaPLr(CategoriaPerformanceLevelRequeridoViewModel objeto)
        {
            try
            {
                SeveridadeFerimentoViewModel severidadeFerimento = objeto.categoriaRisco.SeveridadeFerimento;
                FrequenciaExposicaoPerigoViewModel frequenciaExposicaoPerigo = objeto.categoriaRisco.FrequenciaExposicaoPerigo;
                PossibilidadeEvitarPerigoViewModel possibilidadeEvitarPerigo = objeto.categoriaRisco.PossibilidadeEvitarPerigo;

                return _mapper.Map<CategoriaPerformanceLevelRequeridoDto, CategoriaPerformanceLevelRequeridoViewModel>(_novoRiscoBll.CalcularCategoriaPLr(
                        _mapper.Map<SeveridadeFerimentoViewModel, SeveridadeFerimentoDto>(severidadeFerimento),
                        _mapper.Map<FrequenciaExposicaoPerigoViewModel, FrequenciaExposicaoPerigoDto>(frequenciaExposicaoPerigo),
                        _mapper.Map<PossibilidadeEvitarPerigoViewModel, PossibilidadeEvitarPerigoDto>(possibilidadeEvitarPerigo)));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost]
        [Route("/InserirNovoRisco")]
        public ActionResult<RiscoViewModel> InserirNovoRisco(RiscoViewModel risco)
        {
            try
            {
                risco.ApreciacaoRisco = _mapper.Map<ApreciacaoRiscoDto, ApreciacaoRiscoViewModel>(_editarApreciacaoBll.BuscarApreciacaoRisco(risco.IdAPreciacaoRisco));

                return _mapper.Map<RiscoDto, RiscoViewModel>(_novoRiscoBll.InserirNovoRisco(_mapper.Map<RiscoViewModel, RiscoDto>(risco)));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}
