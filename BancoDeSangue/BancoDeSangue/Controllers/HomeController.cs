using BancoDeSangue.Data;
using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Controllers
{
    public class HomeController : Controller
    {

        private readonly BancoContext _context;

        public HomeController(BancoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.qtdUsuarios = _context.Usuarios.Count();
            ViewBag.qtdInstituicoes = _context.Instituicoes.Count();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
