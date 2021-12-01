using AutoMapper;
using SGAR.Dal.EditarApreciacao;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Model.Models;
using System.Collections.Generic;

namespace SGAR.Bll.EditarApreciacao
{
    public class EditarApreciacaoBll
    {
        private readonly EditarApreciacaoDal _editarApreciacaoDal;
        private readonly IMapper _mapper;

        public EditarApreciacaoBll(EditarApreciacaoDal editarApreciacaoDal, IMapper mapper)
        {
            _editarApreciacaoDal = editarApreciacaoDal;
            _mapper = mapper;
        }

        public ApreciacaoRiscoDto BuscarApreciacaoRisco(int idApreciacaoRisco)
        {
            return _mapper.Map<ApreciacaoRisco, ApreciacaoRiscoDto>(_editarApreciacaoDal.BuscarApreciacaoRisco(idApreciacaoRisco));
        }

        public ApreciacaoRiscoDto AtualizarApreciacaoRisco(ApreciacaoRiscoDto apreciacaoRisco)
        {
            return _mapper.Map<ApreciacaoRisco, ApreciacaoRiscoDto>(_editarApreciacaoDal.AtualizarApreciacaoRisco(_mapper.Map<ApreciacaoRiscoDto, ApreciacaoRisco>(apreciacaoRisco)));
        }

        public List<TabelaRiscosDto> BuscarListaRiscos(int idApreciacao)
        {
            List<RiscoDto> listaRiscos = _mapper.Map<List<Risco>, List<RiscoDto>>(_editarApreciacaoDal.BuscarListaRiscos(idApreciacao));

            List<TabelaRiscosDto> retorno = new List<TabelaRiscosDto>();

            foreach(var risco in listaRiscos)
            {
                retorno.Add(new TabelaRiscosDto()
                {
                    Id = risco.Id,
                    CicloVida = risco.CicloVida.Descricao,
                    Tarefa = risco.Tarefa.Descricao,
                    Atividade = risco.Atividade,
                    TipoGrupoPerigo = risco.TipoGrupoPerigo.Descricao,
                    Dano = risco.Dano.Descricao,
                    Onde = risco.Onde,
                    RiscoABNT12100 = risco.RiscoABNT12100.Descricao,
                    MedidaProtecaoSugerida = risco.MedidaProtecaoSugerida,
                    ValorCalculadoHRNAntes = risco.HRNAntes.ValorCalculado,
                    FaixaHRNAntes = risco.HRNAntes.FaixaHRN.Descricao,
                    Categoria = risco.CategoriaRisco.DescricaoCategoria.Descricao,
                    PerformanceLevelRequerido = risco.PerformanceLevelRequerido.DescricaoPerformanceLevel.Descricao,
                    ValorCalculadoHRNDepois = risco.HRNDepois.ValorCalculado,
                    FaixaHRNDepois = risco.HRNDepois.FaixaHRN.Descricao
                });
            }

            return retorno;
        }
    }
}
