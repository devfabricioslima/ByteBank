using ByteBank.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Controllers
{
    public class DiretorController : Controller
    {
        [HttpGet]
        public IActionResult Diretores()
        {
            return View(DadosFuncionario.TodosFuncionarios());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Diretor diretor)
        {
            DadosFuncionario.CadastrarFuncionario(diretor);

            return View();
        }

        public IActionResult Remover(int id)
        {
            DadosFuncionario.DeletarFuncinario(id);
            return View();
        }
    }
}
