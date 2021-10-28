using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.NovaApreciacao;
using SGAR.Dto.Equipamento;
using SGAR.Dto.Pessoa;
using SGAR.WebApi.ViewModel.Equipamento;
using SGAR.WebApi.ViewModel.Pessoa;
using System.Collections.Generic;

namespace SGAR.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NovaApreciacaoController : ControllerBase
    {
        private readonly NovaApreciacaoBll _novaApreciacaoBll;
        private readonly IMapper _mapper;

        public NovaApreciacaoController(NovaApreciacaoBll novaApreciacaoBll, IMapper mapper)
        {
            _novaApreciacaoBll = novaApreciacaoBll;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/BuscarEquipamentos")]
        public ActionResult<List<EquipamentoViewModel>> BuscarEquipamentos()
        {
            return _mapper.Map<List<EquipamentoDto>, List<EquipamentoViewModel>>(_novaApreciacaoBll.BuscarEquipamentos());
        }

        [HttpGet]
        [Route("/BuscarPessoasPorEmpresa")]
        public ActionResult<List<PessoaViewModel>> BuscarPessoasPorEmpresa()
        {
            return _mapper.Map<List<PessoaDTO>, List<PessoaViewModel>>(_novaApreciacaoBll.BuscarPessoasPorEmpresa(1));
        }
    }
}
