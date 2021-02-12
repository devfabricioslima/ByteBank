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
            Cliente gabriela = new Cliente()
            {
                Nome = "Gabriela",
                CPF = "333444663",
                Profissao = "Desenvolvedora"
            };

            Agencia agenciaGabriela = new Agencia()
            {
                NumAgencia = 1653,
                Conta = 467272,
            };

            ContaCorrente contaGabriela = new ContaCorrente()
            {
                Titular = gabriela,
                Agencia = agenciaGabriela
            };

            //ViewData["saldo"] = contaGabriela.ObterSaldo();
            

            return View(contaGabriela);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
