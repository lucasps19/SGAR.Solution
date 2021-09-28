using SGAR.Dto.Empresa;

namespace SGAR.WebApi.ViewModel.Empresa
{
    public class EmpresaViewModel
    {
        public int? Id { get; set; }
        public string Nome { get; set; }

        public static implicit operator EmpresaViewModel(EmpresaDto empresa)
        {
            return new EmpresaViewModel
            {
                Id = empresa.Id,
                Nome = empresa.Nome
            };
        }
    }
}
