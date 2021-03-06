using AutoMapper;
using SGAR.Dto.NR12100;
using SGAR.Model.Models.NR12100;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class TarefaProfile : Profile
    {
        public TarefaProfile()
        {
            CreateMap<Tarefa, TarefaDto>().ReverseMap();
        }
    }
}
