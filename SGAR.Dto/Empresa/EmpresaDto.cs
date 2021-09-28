using System.Collections.Generic;

namespace SGAR.Dto.Empresa
{
    public class EmpresaDto
    {
        public EmpresaDto()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public static implicit operator EmpresaDto(Model.Models.Empresa empresa)
        {
            return new EmpresaDto
            {
                Id = empresa.Id,
                Nome = empresa.Nome
            };
        }

        public static implicit operator Model.Models.Empresa(EmpresaDto empresa)
        {
            return new Model.Models.Empresa
            {
                Id = empresa.Id,
                Nome = empresa.Nome
            };
        }
    }
}
