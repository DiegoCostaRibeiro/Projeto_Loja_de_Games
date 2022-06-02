using Loja_de_Games.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja_de_Games.Persistence 
{
    public class LojaContext : DbContext 
    {
        public DbSet<Jogo> Jogos { get; set;}
	    public DbSet<Cliente> Clientes { get; set;}
        public DbSet<Venda> Vendas { get; set;}

        public LojaContext(DbContextOptions op):base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}