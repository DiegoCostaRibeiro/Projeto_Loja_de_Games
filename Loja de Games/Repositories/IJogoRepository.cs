using Loja_de_Games.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Loja_de_Games.Repositories
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);

        void Atualizar(Jogo jogo);

        void Excluir(int id);

        Jogo BuscarPorId(int id);

        List<Jogo> Listar();

        List<Jogo> BuscarPor(Expression<Func<Jogo, bool>> filtro);

        void Salvar();
    }
}