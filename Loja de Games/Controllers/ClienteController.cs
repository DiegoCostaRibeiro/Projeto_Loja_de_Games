using Loja_de_Games.Models;
using Loja_de_Games.Persistence;
using Loja_de_Games.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Loja_de_Games.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository _repository)
        {
            _clienteRepository = _repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            List<Cliente> todosOsClientes = _clienteRepository.Listar();
            return View(todosOsClientes);
        }

        [HttpGet]
        public IActionResult Cadastrar() //formulário de cadastro
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente Cliente)
        {
            _clienteRepository.Cadastrar(Cliente);
            _clienteRepository.Salvar();
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            _clienteRepository.Excluir(id);
            _clienteRepository.Salvar();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id) //formulário de edição
        {
            Cliente cliente = _clienteRepository.BuscarPorId(id);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            _clienteRepository.Atualizar(cliente);
            _clienteRepository.Salvar();
            return RedirectToAction("Listar");
        }
    }
}
