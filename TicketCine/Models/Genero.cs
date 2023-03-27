using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("generos")]
    public class Genero
    {
        [Key]
        public int IdGenero { get; set; }
        public string Tipo { get; set; }

    }
}
