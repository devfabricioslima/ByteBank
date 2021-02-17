using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Controllers
{
    public class DiretorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
