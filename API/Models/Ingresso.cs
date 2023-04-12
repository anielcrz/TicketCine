using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("ingressos")]
    public class Ingresso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdIngresso { get; set; }
        public string CodIngresso { get; set; }
        public Assento Assento { get; set; }
        public Sessao Sessao { get; set; }  
    }
}
