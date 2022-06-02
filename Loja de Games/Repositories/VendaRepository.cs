using Loja_de_Games.Models;
using Loja_de_Games.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Loja_de_Games.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private LojaContext _context;
        public VendaRepository(LojaContext context)
        {
            _context = context;
        }

        public void Atualizar(Venda Venda)
        {
            _context.Vendas.Update(Venda);
        }

        public List<Venda> BuscarPor(Expression<Func<Venda, bool>> filtro)
        {
            return _context.Vendas.Where(filtro).ToList();
        }

        public Venda BuscarPorId(int id)
        {
            return _context.Vendas.Where(x => x.VendaId == id).FirstOrDefault();
        }

        public void Cadastrar(Venda Venda)
        {
            _context.Vendas.Add(Venda);

        }

        public void Excluir(int id)
        {
            Venda Venda = _context.Vendas.Find(id);
            _context.Vendas.Remove(Venda);
        }

        public List<Venda> Listar()
        {
            return _context.Vendas.Include(x => x.Jogo).Include(x => x.Cliente).ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
