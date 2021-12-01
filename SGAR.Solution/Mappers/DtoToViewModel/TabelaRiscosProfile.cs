using AutoMapper;
using SGAR.Dto.Apreciacao_de_Risco;
using SGAR.WebApi.ViewModel.ApreciacaoRisco;

namespace SGAR.WebApi.Mappers.DtoToViewModel
{
    public class TabelaRiscosProfile : Profile
    {
        public TabelaRiscosProfile()
        {
            CreateMap<TabelaRiscosDto, TabelaRiscosViewModel>().ReverseMap();
        }
    }
}
