using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.WebApi.ViewModel.NR12100;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class TarefaProfile : Profile
    {
        public TarefaProfile()
        {
            CreateMap<TarefaDto, TarefaViewModel>().ReverseMap();
        }
    }
}
