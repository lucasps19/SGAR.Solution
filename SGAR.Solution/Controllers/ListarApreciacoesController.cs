using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.ListarApreciacoes;
using SGAR.Dto.Equipamento;
using SGAR.WebApi.ViewModel.Equipamento;
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
        [Route("/BuscarTiposEquipamentos")]
        public ActionResult<List<TipoEquipamentoViewModel>> BuscarTiposEquipamentos()
        {
            return _mapper.Map<List<TipoEquipamentoDto>, List<TipoEquipamentoViewModel>>(_listarApreciacoesBll.BuscarTiposEquipamentos());
        }
    }
}
