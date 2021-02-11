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
            ContaCorrente contaDaGabriela = new ContaCorrente();

            var nome = contaDaGabriela.Titular.Nome = "Gabriela";
            var cpf = contaDaGabriela.Titular.CPF = "33377899865";
            var profissao = contaDaGabriela.Titular.Profissao = "Desenvolvedora";
            ViewBag.Titular = nome;
            ViewBag.Cpf = cpf;
            ViewBag.Profissao = profissao;
            ViewBag.Agencia = contaDaGabriela.Agencia;
            ViewBag.Numero = contaDaGabriela.Numero;
            ViewBag.Saldo = contaDaGabriela.Saldo;

            ViewBag.Deposito = contaDaGabriela.Depositar(500);

            ViewBag.Saldo = contaDaGabriela.Saldo;

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
