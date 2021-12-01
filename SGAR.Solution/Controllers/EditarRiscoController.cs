using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.EditarRisco;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.Dto.HRN;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;
using SGAR.WebApi.ViewModel.Categoria_e_Performance_Level;
using SGAR.WebApi.ViewModel.HRN;
using System;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EditarRiscoController : Controller
    {
        private readonly EditarRiscoBll _editarRiscoBll;
        private readonly IMapper _mapper;

        public EditarRiscoController(EditarRiscoBll editarRiscoBll, IMapper mapper)
        {
            _editarRiscoBll = editarRiscoBll;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/BuscarRisco")]
        public ActionResult<RiscoViewModel> BuscarRisco(int idRisco)
        {
            try
            {
                return _mapper.Map<RiscoDto, RiscoViewModel>(_editarRiscoBll.BuscarRisco(idRisco));
            }
            catch(Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarHRNAntes")]
        public ActionResult<HRNAntesViewModel> BuscarHRNAntes(int idHrnAntes)
        {
            try
            {
                return _mapper.Map<HRNAntesDto, HRNAntesViewModel>(_editarRiscoBll.BuscarHRNAntes(idHrnAntes));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarHRNDepois")]
        public ActionResult<HRNDepoisViewModel> BuscarHRNDepois(int idHrnDepois)
        {
            try
            {
                return _mapper.Map<HRNDepoisDto, HRNDepoisViewModel>(_editarRiscoBll.BuscarHRNDepois(idHrnDepois));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpGet]
        [Route("/BuscarCatPLr")]
        public ActionResult<CategoriaPerformanceLevelRequeridoViewModel> BuscBuscarCategoriaPerformanceLevelRequeridoarHRNDepois(int idCategoria, int idPlr)
        {
            try
            {
                return _mapper.Map<CategoriaPerformanceLevelRequeridoDto, CategoriaPerformanceLevelRequeridoViewModel>(_editarRiscoBll.BuscarCategoriaPerformanceLevelRequerido(idCategoria, idPlr));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}
