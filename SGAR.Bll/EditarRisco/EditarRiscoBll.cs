using AutoMapper;
using SGAR.Dal.EditarRisco;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.Dto.Categoria_e_Performance_Level;
using SGAR.Dto.HRN;
using SGAR.Model.Models;
using SGAR.Model.Models.Categoria_e_Performance_Level;
using SGAR.Model.Models.HRN;

namespace SGAR.Bll.EditarRisco
{
    public  class EditarRiscoBll
    {
        private readonly EditarRiscoDal _editarRiscoDal;
        private readonly IMapper _mapper;

        public EditarRiscoBll(EditarRiscoDal editarRiscoDal, IMapper mapper)
        {
            _editarRiscoDal = editarRiscoDal;
            _mapper = mapper;
        }

        public RiscoDto BuscarRisco(int idRisco)
        {
            return _mapper.Map<Risco, RiscoDto>(_editarRiscoDal.BuscarRisco(idRisco));
        }

        public HRNAntesDto BuscarHRNAntes(int idHrnAntes)
        {
            return _mapper.Map<HRNAntes, HRNAntesDto>(_editarRiscoDal.BuscarHRNAntes(idHrnAntes));
        }

        public HRNDepoisDto BuscarHRNDepois(int idHrnDepois)
        {
            return _mapper.Map<HRNDepois, HRNDepoisDto>(_editarRiscoDal.BuscarHRNDepois(idHrnDepois));
        }

        public CategoriaPerformanceLevelRequeridoDto BuscarCategoriaPerformanceLevelRequerido(int idCategoria, int idPlr)
        {
            CategoriaRiscoDto categoria = _mapper.Map<CategoriaRisco, CategoriaRiscoDto>(_editarRiscoDal.BuscarCategoriaRisco(idCategoria));

            PerformanceLevelRequeridoDto plr = _mapper.Map<PerformanceLevelRequerido, PerformanceLevelRequeridoDto>(_editarRiscoDal.BuscarPerformanceLevelRequerido(idPlr));

            CategoriaPerformanceLevelRequeridoDto retorno = new CategoriaPerformanceLevelRequeridoDto()
            {
                categoriaRisco = categoria,
                performanceLevelRequerido = plr
            };

            return retorno;
        }
    }
}
