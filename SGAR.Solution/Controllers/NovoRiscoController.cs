using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.NovoRisco;
using SGAR.Dto.HRN;
using SGAR.Dto.NR12100;
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
        private readonly IMapper _mapper;

        public NovoRiscoController(NovoRiscoBll novoRiscoBll, IMapper mapper)
        {
            _novoRiscoBll = novoRiscoBll;
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
    }
}
