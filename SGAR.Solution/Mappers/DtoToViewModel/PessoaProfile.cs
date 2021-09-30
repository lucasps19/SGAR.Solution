using AutoMapper;
using SGAR.Dto.Pessoa;
using SGAR.WebApi.ViewModel.Pessoa;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<PessoaDTO, PessoaViewModel>().ReverseMap();
        }
    }
}
