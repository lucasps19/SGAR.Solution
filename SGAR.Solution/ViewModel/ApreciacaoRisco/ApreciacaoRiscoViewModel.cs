using SGAR.WebApi.ViewModel.Pessoa;
using System;
using System.Collections.Generic;

namespace SGAR.WebApi.ViewModel.ApreciacaoRisco
{
    public class ApreciacaoRiscoViewModel
    {
        public int Id { get; set; }
        public DateTime DataApreciacao { get; set; }
        public string LimiteUso { get; set; }
        public string LimiteEspaco { get; set; }
        public string LimiteTempo { get; set; }
        public int IdEquipamento { get; set; }
        public List<PessoaViewModel> Pessoas { get; set; }
    }
}