using AutoMapper;
using SGAR.Dal.NovaApreciacao;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Dto.Equipamento;
using SGAR.Dto.Pessoa;
using SGAR.Model.Models;
using System.Collections.Generic;

namespace SGAR.Bll.NovaApreciacao
{
    public class NovaApreciacaoBll
    {
        private readonly NovaApreciacaoDal _novaApreciacaoDal;
        private readonly IMapper _mapper;

        public NovaApreciacaoBll(NovaApreciacaoDal novaApreciacaoDal, IMapper mapper)
        {
            _novaApreciacaoDal = novaApreciacaoDal;
            _mapper = mapper;
        }

        public List<EquipamentoDto> BuscarEquipamentos(int idEmpresa)
        {
            return _mapper.Map<List<Equipamento>, List<EquipamentoDto>>(_novaApreciacaoDal.BuscarEquipamentos(idEmpresa));
        }

        public List<PessoaDTO> BuscarPessoasPorEmpresa(int idEmpresa)
        {
            return _mapper.Map<List<Pessoa>, List<PessoaDTO>>(_novaApreciacaoDal.BuscarPessoasPorEmpresa(idEmpresa));
        }

        public List<TipoEquipamentoDto> BuscarTiposEquipamentos()
        {
            return _mapper.Map<List<TipoEquipamento>, List<TipoEquipamentoDto>>(_novaApreciacaoDal.BuscarTiposEquipamentos());
        }

        public void CadastrarEquipamento(EquipamentoDto equipamento)
        {
            _novaApreciacaoDal.CadastrarEquipamento(_mapper.Map<EquipamentoDto, Equipamento>(equipamento));
        } 

        public void CadastrarTipoEquipamento(TipoEquipamentoDto tipoEquipamento)
        {
            _novaApreciacaoDal.CadastrarTipoEquipamento(_mapper.Map<TipoEquipamentoDto, TipoEquipamento>(tipoEquipamento));
        }

        public ApreciacaoRiscoDto IncluirNovaApreciacaoRisco(ApreciacaoRiscoDto novaApreciacaoRisco)
        {
            ApreciacaoRiscoDto apreciacaoRisco = new ApreciacaoRiscoDto();

            apreciacaoRisco = _mapper.Map<ApreciacaoRisco, ApreciacaoRiscoDto>(_novaApreciacaoDal.IncluirNovaApreciacaoRisco(_mapper.Map<ApreciacaoRiscoDto, ApreciacaoRisco>(novaApreciacaoRisco)));

            return apreciacaoRisco;
        }

    }
}
