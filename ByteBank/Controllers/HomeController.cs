﻿using ByteBank.Models;
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
        public IActionResult Funcionarios()
        {
            return View(DadosFuncionario.TodosFuncionarios);
        }

        public IActionResult Remover(int id)
        {
            DadosFuncionario.DeletarFuncinario(id);
            return View("Funcionarios", DadosFuncionario.TodosFuncionarios);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
