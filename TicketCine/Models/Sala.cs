using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("salas")]
    public class Sala
    {
        [Key]
        public int Numero { get; set; }
        public int QtdAssentos { get; set; }
    }
}
