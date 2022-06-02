using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Loja_de_Games.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        
        public Jogo Jogo { get; set;}
        public int JogoId { get; set;}

        //public List<Cliente> Clientes { get; set;}

        public Cliente Cliente { get; set; }

        public int ClienteId { get; set;}

        public DateTime Data { get; set;}

        //public List<Jogo> Jogos { get; set;}
    }
}
