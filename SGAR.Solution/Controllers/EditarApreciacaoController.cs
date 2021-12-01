using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.EditarApreciacao;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;
using System;
using System.Collections.Generic;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EditarApreciacaoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly EditarApreciacaoBll _editarApreciacaoBll;

        public EditarApreciacaoController(EditarApreciacaoBll editarApreciacaoBll, IMapper mapper)
        {
            _editarApreciacaoBll = editarApreciacaoBll;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/BuscarApreciacaoRisco")]
        public ActionResult<ApreciacaoRiscoViewModel> BuscarApreciacaoRisco(string idApreciacao)
        {
            ApreciacaoRiscoViewModel retorno = new ApreciacaoRiscoViewModel();

            int idApreciacaoRisco = Int32.Parse(idApreciacao);

            try
            {
                retorno = _mapper.Map<ApreciacaoRiscoDto, ApreciacaoRiscoViewModel>(_editarApreciacaoBll.BuscarApreciacaoRisco(idApreciacaoRisco));

                return retorno;
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost]
        [Route("/AtualizarApreciacaoRisco")]
        public ActionResult<ApreciacaoRiscoViewModel> AtualizarApreciacaoRisco(ApreciacaoRiscoViewModel apreciacaoRisco)
        {
            try
            {
                return _mapper.Map<ApreciacaoRiscoDto, ApreciacaoRiscoViewModel>(_editarApreciacaoBll.AtualizarApreciacaoRisco(_mapper.Map<ApreciacaoRiscoViewModel, ApreciacaoRiscoDto>(apreciacaoRisco)));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }

        }

        [HttpGet]
        [Route("/BuscarListaRiscos")]
        public ActionResult<List<TabelaRiscosViewModel>> BuscarListaRiscos(int idApreciacao)
        {
            try
            {
                return _mapper.Map<List<TabelaRiscosDto>, List<TabelaRiscosViewModel>>(_editarApreciacaoBll.BuscarListaRiscos(idApreciacao));
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}
