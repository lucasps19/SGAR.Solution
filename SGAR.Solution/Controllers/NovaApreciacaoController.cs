using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.CadastroUsuarios;
using SGAR.Bll.NovaApreciacao;
using SGAR.Dto.Empresa;
using SGAR.Dto.Equipamento;
using SGAR.Dto.Pessoa;
using SGAR.WebApi.ViewModel.Empresa;
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
        private readonly CadastroUsuarioBll _cadastroUsuarioBll;
        private readonly IMapper _mapper;

        public NovaApreciacaoController(NovaApreciacaoBll novaApreciacaoBll, CadastroUsuarioBll cadastroUsuarioBll, IMapper mapper)
        {
            _novaApreciacaoBll = novaApreciacaoBll;
            _cadastroUsuarioBll = cadastroUsuarioBll;
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

        [HttpGet]
        [Route("/BuscarTiposEquipamentos")]
        public ActionResult<List<TipoEquipamentoViewModel>> BuscarTiposEquipamentos()
        {
            return _mapper.Map<List<TipoEquipamentoDto>, List<TipoEquipamentoViewModel>>(_novaApreciacaoBll.BuscarTiposEquipamentos());
        }

        [HttpGet]
        [Route("/BuscarEmpresas")]
        public ActionResult<List<EmpresaViewModel>> BuscarEmpresasCadastradas()
        {
            return _mapper.Map<List<EmpresaDto>, List<EmpresaViewModel>>(_cadastroUsuarioBll.BuscarEmpresasCadastradas());
        }
    }
}
