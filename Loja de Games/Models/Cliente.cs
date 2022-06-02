using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja_de_Games.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required, Display (Name ="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
       
        public ICollection<Venda> Vendas { get; set;} //ligação com as vendas
    }
}
