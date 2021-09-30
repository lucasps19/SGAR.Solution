using AutoMapper;
using SGAR.Dto.Empresa;
using SGAR.Model.Models;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            CreateMap<Empresa, EmpresaDto>().ReverseMap();
        }
    }
}
