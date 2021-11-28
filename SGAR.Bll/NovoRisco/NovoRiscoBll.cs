using AutoMapper;
using SGAR.Dal.NovoRisco;
using SGAR.Dto.HRN;
using SGAR.Dto.NR12100;
using SGAR.Model.Models.HRN;
using SGAR.Model.Models.NR12100;
using System.Collections.Generic;

namespace SGAR.Bll.NovoRisco
{
    public class NovoRiscoBll
    {
        private readonly NovoRiscoDal _novoRiscoDal;
        private readonly IMapper _mapper;

        public NovoRiscoBll(NovoRiscoDal novoRiscoDal, IMapper mapper)
        {
            _novoRiscoDal = novoRiscoDal;
            _mapper = mapper;
        }

        public List<CicloVidaDto> BuscarCicloVida()
        {
            return _mapper.Map<List<CicloVida>, List<CicloVidaDto>>(_novoRiscoDal.BuscarCicloVida());
        }

        public List<TarefaDto> BuscarTarefas(int idCicloVida)
        {
            return _mapper.Map<List<Tarefa>, List<TarefaDto>>(_novoRiscoDal.BuscarTarefas(idCicloVida));
        }

        public List<TipoGrupoPerigoDto> BuscarTipoGrupoPerigo()
        {
            return _mapper.Map<List<TipoGrupoPerigo>, List<TipoGrupoPerigoDto>>(_novoRiscoDal.BuscarTipoGrupoPerigo());
        }

        public List<DanoDto> BuscarDanos(int idTipoGrupoPerigo)
        {
            return _mapper.Map<List<Dano>, List<DanoDto>>(_novoRiscoDal.BuscarDanos(idTipoGrupoPerigo));
        }

        public List<RiscoABNT12100Dto> BuscarRiscosABNT12100()
        {
            return _mapper.Map<List<RiscoABNT12100>, List<RiscoABNT12100Dto>>(_novoRiscoDal.BuscarRiscosABNT12100());
        }

        public List<GrauPossivelLesaoDto> BuscarGLPHRN()
        {
            return _mapper.Map<List<GrauPossivelLesao>, List<GrauPossivelLesaoDto>>(_novoRiscoDal.BuscarGLPHRN());
        }

        public List<PossibilidadeOcorrenciaDto> BuscarPOHRN()
        {
            return _mapper.Map<List<PossibilidadeOcorrencia>, List<PossibilidadeOcorrenciaDto>>(_novoRiscoDal.BuscarPOHRN());
        }

        public List<FrequenciaExposicaoDto> BuscarFEHRN()
        {
            return _mapper.Map<List<FrequenciaExposicao>, List<FrequenciaExposicaoDto>>(_novoRiscoDal.BuscarFEHRN());
        }

        public List<NumeroPessoasDto> BuscarNPHRN()
        {
            return _mapper.Map<List<NumeroPessoas>, List<NumeroPessoasDto>>(_novoRiscoDal.BuscarNPHRN());
        }

        public HRNAntesDto CalcularHrnAntes(HRNAntesDto hrnAntes)
        {
            string faixaCalculada = null;

            decimal valorGlp = hrnAntes.GrauPossivelLesao.Valor;
            decimal valorPo = hrnAntes.PossibilidadeOcorrencia.Valor;
            decimal valorFe = hrnAntes.FrequenciaExposicao.Valor;
            decimal valorNp = hrnAntes.NumeroPessoas.Valor;

            decimal valorHRNCalculado = valorGlp * valorPo * valorFe * valorNp;

            hrnAntes.ValorCalculado = decimal.ToInt32(valorHRNCalculado);

            List<FaixaHRNDto> faixaHRN = _mapper.Map<List<FaixaHRN>, List<FaixaHRNDto>>(_novoRiscoDal.BuscarFaixasHRN());

            if(0 <= valorHRNCalculado && valorHRNCalculado <= 1)
            {
                faixaCalculada = "0 A 1";
            }
            else if(1 < valorHRNCalculado && valorHRNCalculado <= 5)
            {
                faixaCalculada = "1 A 5";
            }
            else if (5 < valorHRNCalculado && valorHRNCalculado <= 10)
            {
                faixaCalculada = "5 A 10";
            }
            else if (10 < valorHRNCalculado && valorHRNCalculado <= 50)
            {
                faixaCalculada = "10 A 50";
            }
            else if (50 < valorHRNCalculado && valorHRNCalculado <= 100)
            {
                faixaCalculada = "50 A 100";
            }
            else if (100 < valorHRNCalculado && valorHRNCalculado <= 500)
            {
                faixaCalculada = "100 A 500";
            }
            else if (500 < valorHRNCalculado && valorHRNCalculado <= 1000)
            {
                faixaCalculada = "500 A 1000";
            }
            else if (valorHRNCalculado > 1000)
            {
                faixaCalculada = "MAIOR QUE 1000";
            }

            foreach(var faixa in faixaHRN)
            {
                if(faixa.Faixa == faixaCalculada)
                {
                    hrnAntes.FaixaHRN = faixa;
                }
            }

            return hrnAntes;
        }
    }
}
