using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("assentos")]
    public class Assento
    {
        [Key]
        public string Identificador { get; set; }
        public bool Ocupado { get; set; }
        public Sala Sala { get; set; }  
    }
}
