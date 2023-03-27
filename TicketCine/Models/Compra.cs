namespace TicketCine.Models
{
    public class Compra
    {
        public int idCompra { get; set; }
        public List<Ingresso> Ingressos { get; set; }   
    }
}
