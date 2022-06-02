using Loja_de_Games.Models;
using Loja_de_Games.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Loja_de_Games.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private LojaContext _context;
        public ClienteRepository(LojaContext context)
        {
            _context = context;
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
        }

        public List<Cliente> BuscarPor(Expression<Func<Cliente, bool>> filtro)
        {
            return _context.Clientes.Where(filtro).ToList();
        }

        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.Where(x => x.ClienteId == id).FirstOrDefault();
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public void Excluir(int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            _context.Clientes.Remove(cliente);
        }

        public List<Cliente> Listar()
        {
            return _context.Clientes.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
