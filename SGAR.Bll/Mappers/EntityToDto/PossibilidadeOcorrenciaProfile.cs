using AutoMapper;
using SGAR.Dto.HRN;
using SGAR.Model.Models.HRN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    class PossibilidadeOcorrenciaProfile : Profile
    {
        public PossibilidadeOcorrenciaProfile()
        {
            CreateMap<PossibilidadeOcorrencia, PossibilidadeOcorrenciaDto>().ReverseMap();
        }
    }
}
