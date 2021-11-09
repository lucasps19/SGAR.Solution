using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SGAR.Bll.CadastroUsuarios;
using SGAR.Bll.NovaApreciacao;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Dto.Empresa;
using SGAR.Dto.Equipamento;
using SGAR.Dto.Pessoa;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;
using SGAR.WebApi.ViewModel.Empresa;
using SGAR.WebApi.ViewModel.Equipamento;
using SGAR.WebApi.ViewModel.Pessoa;
using System;
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

        [HttpPost]
        [Route("/CadastrarEquipamento")]
        public ActionResult CadastrarEquipamento(EquipamentoViewModel equipamento)
        {
            equipamento.Nome = equipamento.Nome.ToUpper();

            try
            {
                _novaApreciacaoBll.CadastrarEquipamento(_mapper.Map<EquipamentoViewModel, EquipamentoDto>(equipamento));

                return Ok();
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost]
        [Route("/CadastrarTipoEquipamento")]
        public ActionResult CadastrarTipoEquipamento(TipoEquipamentoViewModel tipoEquipamento)
        {
            tipoEquipamento.Descricao = tipoEquipamento.Descricao.ToUpper();

            try
            {
                _novaApreciacaoBll.CadastrarTipoEquipamento(_mapper.Map<TipoEquipamentoViewModel, TipoEquipamentoDto>(tipoEquipamento));

                return Ok();
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost]
        [Route("/IncluirNovaApreciacao")]
        public ActionResult<ApreciacaoRiscoViewModel> IncluirNovaApreciacaoRisco(ApreciacaoRiscoViewModel novaApreciacaoRisco)
        {
            novaApreciacaoRisco.DataApreciacao = DateTime.Now;

            ApreciacaoRiscoViewModel apreciacaoRisco = new ApreciacaoRiscoViewModel();

            try
            {
                apreciacaoRisco = _mapper.Map<ApreciacaoRiscoDto, ApreciacaoRiscoViewModel>(_novaApreciacaoBll.IncluirNovaApreciacaoRisco(_mapper.Map<ApreciacaoRiscoViewModel, ApreciacaoRiscoDto>(novaApreciacaoRisco)));

                return apreciacaoRisco;
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    }
}
