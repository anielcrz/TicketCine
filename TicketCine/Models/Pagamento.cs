namespace TicketCine.Models
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        public DateTime Data { get; set; }
    }
}
