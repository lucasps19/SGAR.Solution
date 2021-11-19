using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.EditarApreciacao;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;
using System;

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
            catch(Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}
