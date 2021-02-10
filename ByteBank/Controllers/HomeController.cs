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
        public IActionResult Index()
        {
            ContaCorrente contaDaGabriela = new ContaCorrente() { 
                Titular = "Gabriela", Agencia = 1653, Numero = 467272
            };

            ViewBag.Titular = contaDaGabriela.Titular;
            ViewBag.Agencia = contaDaGabriela.Agencia;
            ViewBag.Numero = contaDaGabriela.Numero;
            ViewBag.Saldo = contaDaGabriela.Saldo;

            ViewBag.Deposito = contaDaGabriela.Depositar(500);

            ViewBag.Saldo = contaDaGabriela.Saldo;



            ContaCorrente contaDoBruno = new ContaCorrente()
            {
                Titular = "Bruno",
                Agencia = 1052,
                Numero = 856
            };

            ViewBag.Nome2 = contaDoBruno.Titular;
            ViewBag.Saldo2 = contaDoBruno.Saldo;

            ViewBag.Transferir =  contaDaGabriela.Transferir(200, contaDoBruno);
            ViewBag.Saldo2 = contaDoBruno.Saldo;



            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
