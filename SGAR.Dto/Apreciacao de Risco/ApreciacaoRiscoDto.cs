using SGAR.Dto.Equipamento;
using SGAR.Dto.Pessoa;
using System;
using System.Collections.Generic;

namespace SGAR.Dto.Apreciacao_de_Risco
{
    public class ApreciacaoRiscoDto
    {
        public int Id { get; set; }
        public DateTime DataApreciacao { get; set; }
        public string LimiteUso { get; set; }
        public string LimiteEspaco { get; set; }
        public string LimiteTempo { get; set; }
        public EquipamentoDto Equipamento { get; set; }
        public List<PessoaDTO> Pessoas { get; set; }
    }
}
