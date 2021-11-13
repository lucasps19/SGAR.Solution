using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.ListarApreciacoes;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;
using System;
using System.Collections.Generic;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ListarApreciacoesController : ControllerBase
    {
        private readonly ListarApreciacoesBll _listarApreciacoesBll;
        private readonly IMapper _mapper;

        public ListarApreciacoesController(ListarApreciacoesBll listarApreciacoesBll, IMapper mapper)
        {
            _listarApreciacoesBll = listarApreciacoesBll;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/BuscarApreciacoes")]
        public ActionResult<List<ApreciacaoRiscoViewModel>> BuscarApreciacoesRiscoDoUsuario(string idUsuarioLogado)
        {
            int idUsuario = Int32.Parse(idUsuarioLogado);

            return _mapper.Map<List<ApreciacaoRiscoDto>, List<ApreciacaoRiscoViewModel>>(_listarApreciacoesBll.BuscarApreciacoesRiscoDoUsuario(idUsuario));
        }
    }
}
