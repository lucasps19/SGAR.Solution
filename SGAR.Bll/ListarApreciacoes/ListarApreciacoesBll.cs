using AutoMapper;
using SGAR.Dal.ListarApreciacoes;
using SGAR.Dto.Equipamento;
using SGAR.Dto.HRN;
using SGAR.Model.Models;
using SGAR.Model.Models.HRN;
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

        public List<FaixaHRNDto> BuscarFaixasHRN()
        {
            return _mapper.Map<List<FaixaHRN>, List<FaixaHRNDto>>(_listarApreciacoesDal.BuscarFaixasHRN());
        }
    }
}
