using Loja_de_Games.Models;
using Loja_de_Games.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Loja_de_Games.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private LojaContext _context;
        public JogoRepository(LojaContext context)
        {
            _context = context;
        }

        public void Atualizar(Jogo jogo)
        {
            _context.Jogos.Update(jogo);
        }

        public List<Jogo> BuscarPor(Expression<Func<Jogo, bool>> filtro)
        {
            return _context.Jogos.Where(filtro).ToList();
        }

        public Jogo BuscarPorId(int id)
        {
            return _context.Jogos.Where(x => x.JogoId == id).FirstOrDefault();
        }

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);

        }

        public void Excluir(int id)
        {
            Jogo jogo = _context.Jogos.Find(id);
            _context.Jogos.Remove(jogo);
        }

        public List<Jogo> Listar()
        {
            return _context.Jogos.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
