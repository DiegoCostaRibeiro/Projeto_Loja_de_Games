using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Loja_de_Games.Models
{
    public class Jogo
    {
        public int JogoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required, Display(Name="Usado")]
        public bool EUsado { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required, Display(Name="Gênero")]
        public Genero Genero { get; set; }
        
        public ICollection<Venda> Vendas { get; set;} //ligação com as vendas
    }
}
