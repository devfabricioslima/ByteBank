using ByteBank.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Controllers
{
    public class DesignerController : Controller
    {
        [HttpGet]
        public IActionResult Designers(string cargo)
        {
            return View(DadosFuncionario.TodosCargo(cargo));
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Designer designer)
        {
            DadosFuncionario.CadastrarFuncionario(designer);
            return View();
        }

        public IActionResult Remover(int id)
        {
            DadosFuncionario.DeletarFuncinario(id);
            return RedirectToAction("Designers", DadosFuncionario.TodosFuncionarios());
        }
    }
}
