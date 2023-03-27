using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("ingressos")]
    public class Ingresso
    {
        [Key]
        public string CodIngresso { get; set; }
        public Assento Assento { get; set; }
        public Sessao Sessao { get; set; }  
    }
}
