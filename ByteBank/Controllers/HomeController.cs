using ByteBank.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Extensoes;


namespace ByteBank.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            LerDados.LerStream();

            return View(Dados.Todos_Correntes);
        }

        [HttpGet]
        public IActionResult Funcionarios()
        {
            return View(DadosFuncionario.TodosFuncionarios());
        }

        public IActionResult Remover(int id)
        {
            DadosFuncionario.DeletarFuncinario(id);
            return View("Funcionarios", DadosFuncionario.TodosFuncionarios());
        }

        [HttpGet]
        public IActionResult cadastrar_clientes()
        {
            ViewData["Mensagem"] = "";
            return View();
        }
        [HttpPost]
        public IActionResult cadastrar_clientes(ContaCorrente conta)
        {
            ViewData["Mensagem"] = "";
            try
            {
                Dados.adicionarCliente(conta);
            }
            catch (ArgumentException ex)
            {
                ViewData["Mensagem"] = ex.Message;
                return View("cadastrar_clientes");

            }

            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            Dados.EliminarConta(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ClienteOperacao(int id)
        {
            ViewData["Mensagem"] = "";

            return View(Dados.DadosCliente(id));
        }

        [HttpPost]
        public IActionResult Depositar(ContaCorrente conta, int id)
        {

            //ViewData["Valor"] = 0;
            Dados.Depositar(id, conta.Valor);   

            return View("ClienteOperacao", Dados.DadosCliente(id));
        }

        [HttpPost]
        public IActionResult Sacar(ContaCorrente conta, int id)
        {

            try
            {
                Dados.Sacar(id, conta.Valor);

            }
            catch (SaldoInsuficienteException ex)
            {
                ViewData["Mensagem"] = ex.Message;
                return View("ClienteOperacao", Dados.DadosCliente(id));
            }

            return View("ClienteOperacao", Dados.DadosCliente(id));
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
