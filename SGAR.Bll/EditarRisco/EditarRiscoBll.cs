using AutoMapper;
using SGAR.Dal.EditarRisco;

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
    }
}
