using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string Email { get; set; }
    }
}
