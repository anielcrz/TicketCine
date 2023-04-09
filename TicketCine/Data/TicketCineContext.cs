using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketCine.Models;

namespace TicketCine.Data
{
    public class TicketCineContext: IdentityDbContext
    {
        public TicketCineContext(DbContextOptions<TicketCineContext> options) :
          base(options)
        {
        }
        public DbSet<Assento> Assentos { get; set; }
        public DbSet<Cliente>  Clientes { get; set; }   
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Filme> Filmes { get; set; }    
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Ingresso> Ingressos { get; set; }
        public DbSet<Operador>  Operadores { get; set; }
        public DbSet<Pagamento>  Pagamentos { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
    }
}
