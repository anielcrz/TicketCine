using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("pagamentos")]
    public class Pagamento
    {
        [Key]
        public int IdPagamento { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
    }
}
