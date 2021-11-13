using AutoMapper;
using SGAR.Dal.ListarApreciacoes;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Model.Models;
using System.Collections.Generic;

namespace SGAR.Bll.ListarApreciacoes
{
    public class ListarApreciacoesBll
    {
        private readonly ListarApreciacoesDal _listarApreciacoesDal;
        private readonly IMapper _mapper;

        public ListarApreciacoesBll(ListarApreciacoesDal listarApreciacoesDal, IMapper mapper)
        {
            _listarApreciacoesDal = listarApreciacoesDal;
            _mapper = mapper;
        }

        public List<ApreciacaoRiscoDto> BuscarApreciacoesRiscoDoUsuario(int idUsuario)
        {
            return _mapper.Map<List<ApreciacaoRisco>, List<ApreciacaoRiscoDto>>(_listarApreciacoesDal.BuscarApreciacoesRiscoDoUsuario(idUsuario));
        }
    }
}
