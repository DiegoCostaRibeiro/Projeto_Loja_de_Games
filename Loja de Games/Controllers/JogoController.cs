using Loja_de_Games.Models;
using Loja_de_Games.Persistence;
using Loja_de_Games.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Loja_de_Games.Controllers
{
    public class JogoController : Controller
    {
        private IJogoRepository _jogoRepository;

        public JogoController(IJogoRepository _repository)
        {
            _jogoRepository = _repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar() 
        {
            List<Jogo> todosOsJogos = _jogoRepository.Listar();
            return View(todosOsJogos);
        }

        public IActionResult Clientes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar() //formulário de cadastro
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogo jogo)
        {
            _jogoRepository.Cadastrar(jogo);
            _jogoRepository.Salvar();
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            _jogoRepository.Excluir(id);
            _jogoRepository.Salvar();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id) //formulário de edição
        {
            Jogo jogo = _jogoRepository.BuscarPorId(id);
            return View(jogo);
        }

        [HttpPost]
        public IActionResult Editar(Jogo jogo)
        {
            _jogoRepository.Atualizar(jogo);
            _jogoRepository.Salvar();
            return RedirectToAction("Listar");
        }
    }
}
