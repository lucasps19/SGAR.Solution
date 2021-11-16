namespace SGAR.Dto.NR12100
{
    public class TarefaDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdCicloVida { get; set; }
        public CicloVidaDto CicloVida { get; set; }
    }
}
