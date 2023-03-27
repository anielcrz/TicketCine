using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("sessoes")]
    public class Sessao
    {
        [Key]
        public int IdSessao { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public decimal Valor { get; set; }
        public Filme Filme { get; set; }
        public Sala Sala { get; set; }  
    }
}
