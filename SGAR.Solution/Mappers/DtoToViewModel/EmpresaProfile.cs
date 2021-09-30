using AutoMapper;
using SGAR.Dto.Empresa;
using SGAR.WebApi.ViewModel.Empresa;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    public class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            CreateMap<EmpresaDto, EmpresaViewModel>().ReverseMap();
        }
    }
}
