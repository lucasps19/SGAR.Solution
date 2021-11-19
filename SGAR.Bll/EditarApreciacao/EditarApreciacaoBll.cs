﻿using AutoMapper;
using SGAR.Dal.EditarApreciacao;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Model.Models;

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
    }
}
