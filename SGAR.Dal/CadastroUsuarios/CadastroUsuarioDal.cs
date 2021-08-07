using SGAR.Model.Contexto;

namespace SGAR.Dal.CadastroUsuarios
{
    public class CadastroUsuarioDal
    {
        private readonly Contexto _contexto;

        public CadastroUsuarioDal(Contexto contexto)
        {
            _contexto = contexto;
        }
    }
}
