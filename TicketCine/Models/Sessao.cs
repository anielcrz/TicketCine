namespace TicketCine.Models
{
    public class Sessao
    {
        public int IdSessao { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public decimal Valor { get; set; }
    }
}
