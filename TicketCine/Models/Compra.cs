using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("compras")]
    public class Compra
    {
        [Key]
        public int idCompra { get; set; }
        public List<Ingresso> Ingressos { get; set; }   
    }
}
