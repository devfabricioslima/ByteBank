using ByteBank.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {

            return View(Dados.Todos_Correntes);
        }

        [HttpGet]
        public IActionResult cadastrar_clientes()
        {
            return View();
        }
        [HttpPost]
        public IActionResult cadastrar_clientes(ContaCorrente conta)
        {

            Dados.adicionarCliente(conta);

            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
