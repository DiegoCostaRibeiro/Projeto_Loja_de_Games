using Loja_de_Games.Models;
using Loja_de_Games.Persistence;
using Loja_de_Games.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Loja_de_Games.Controllers
{
    public class VendaController : Controller
    {
        private IVendaRepository _vendaRepository;
        private IJogoRepository _jogoRepository;
        private IClienteRepository _clienteRepository;

        public VendaController(IVendaRepository _vrepository, IJogoRepository _jrepository, IClienteRepository _crepository)
        {
            _vendaRepository = _vrepository;
            _jogoRepository = _jrepository;
            _clienteRepository = _crepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            List<Venda> todosAsVendas = _vendaRepository.Listar();
            return View(todosAsVendas);
        }

        [HttpGet]
        public IActionResult Cadastrar() //formulário de cadastro
        {
            ViewBag.Clientes = _clienteRepository.Listar();
            ViewBag.Jogos = _jogoRepository.Listar();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Venda venda)
        {
            _vendaRepository.Cadastrar(venda);
            _vendaRepository.Salvar();
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            _vendaRepository.Excluir(id);
            _vendaRepository.Salvar();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id) //formulário de edição
        {
            Venda Venda = _vendaRepository.BuscarPorId(id);
            return View(Venda);
        }

        [HttpPost]
        public IActionResult Editar(Venda Venda)
        {
            _vendaRepository.Atualizar(Venda);
            _vendaRepository.Salvar();
            return RedirectToAction("Listar");
        }
    }
}
