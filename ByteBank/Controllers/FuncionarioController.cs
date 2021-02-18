using ByteBank.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarFuncionario(Funcionario funcionario)
        {
            DadosFuncionario.CadastrarFuncionario(funcionario);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult lista_funcionarios()
        {
            return View(DadosFuncionario.TodosFuncionarios);
        }

        public IActionResult RemoverFuncionario(int id)
        {
            DadosFuncionario.DeletarFuncinario(id);

            return RedirectToAction("Index");
        }
    }
}
