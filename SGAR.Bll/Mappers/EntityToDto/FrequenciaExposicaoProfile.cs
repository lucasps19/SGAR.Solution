using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.Model.Models.HRN;

namespace SGAR.Bll.Mappers.EntityToDto
{
    class FrequenciaExposicaoProfile : Profile
    {
        public FrequenciaExposicaoProfile()
        {
            CreateMap<FrequenciaExposicao, FrequenciaExposicaoDto>().ReverseMap();
        }
    }
}
