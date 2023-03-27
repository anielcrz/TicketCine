namespace TicketCine.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string Email { get; set; }
    }
}
