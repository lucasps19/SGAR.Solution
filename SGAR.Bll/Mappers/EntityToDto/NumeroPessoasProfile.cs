using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.Model.Models.HRN;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class NumeroPessoasProfile : Profile
    {
        public NumeroPessoasProfile()
        {
            CreateMap<NumeroPessoas, NumeroPessoasDto>().ReverseMap();
        }
    }
}
