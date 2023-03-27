namespace TicketCine.Models
{
    public class Filme
    {
        public int IdFilme { get; set; }
        public string Titulo { get; set; }    
        public string Descricao { get; set; }
        public string Poster { get; set; }
        public int Duracao { get; set; }
        public Genero Genero { get; set; }
    }
}
