namespace TicketCine.Models
{
    public class Ingresso
    {
        public string CodIngresso { get; set; }
        public Assento Assento { get; set; }
        public Sessao Sessao { get; set; }  
    }
}
