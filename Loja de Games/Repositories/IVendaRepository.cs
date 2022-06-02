using Loja_de_Games.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Loja_de_Games.Repositories
{
    public interface IVendaRepository
    {
        void Cadastrar(Venda venda);

        void Atualizar(Venda venda);

        void Excluir(int id);

        Venda BuscarPorId(int id);

        List<Venda> Listar();

        List<Venda> BuscarPor(Expression<Func<Venda, bool>> filtro);

        void Salvar();
    }
}
