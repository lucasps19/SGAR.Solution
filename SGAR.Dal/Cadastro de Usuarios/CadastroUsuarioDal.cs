using SGAR.Model.Contexto;

namespace SGAR.Dal.Cadastro_de_Usuarios
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
