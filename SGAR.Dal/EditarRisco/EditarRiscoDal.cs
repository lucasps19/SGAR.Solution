using SGAR.Model.Contexto;

namespace SGAR.Dal.EditarRisco
{
    public class EditarRiscoDal
    {
        private readonly Contexto _contexto;

        public EditarRiscoDal(Contexto contexto)
        {
            _contexto = contexto;
        }
    }
}
