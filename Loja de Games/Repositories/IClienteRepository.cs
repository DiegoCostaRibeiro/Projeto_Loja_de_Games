using Loja_de_Games.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Loja_de_Games.Repositories
{
    public interface IClienteRepository
    {
        void Cadastrar(Cliente cliente);

        void Atualizar(Cliente cliente);

        void Excluir(int id);

        Cliente BuscarPorId(int id);

        List<Cliente> Listar();

        List<Cliente> BuscarPor(Expression<Func<Cliente, bool>> filtro);

        void Salvar();
    }
}