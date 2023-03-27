using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCine.Models
{
    [Table("filmes")]
    public class Filme
    {
        [Key]
        public int IdFilme { get; set; }
        public string Titulo { get; set; }    
        public string Descricao { get; set; }
        public string Poster { get; set; }
        public int Duracao { get; set; }
        public Genero Genero { get; set; }
    }
}
