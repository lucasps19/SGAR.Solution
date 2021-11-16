namespace SGAR.WebApi.ViewModel.NR12100
{
    public class TarefaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdCicloVida { get; set; }
        public CicloVidaViewModel CicloVida { get; set; }
    }
}
