using BancoDeSangue.Data;
using BancoDeSangue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Controllers
{
    public class LoginController : Controller
    {

        private readonly BancoContext _context;

        public LoginController(BancoContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> login(UsuarioModel usuario)
        {
            var teste = _context.Usuarios.Where(x => x.email.Equals(usuario.email) && x.senha.Equals(usuario.senha)).FirstOrDefault();

            if (teste != null)
            {
                return RedirectToAction("Privacy", "Home");
            }
            else
            {

                return RedirectToAction("Index");
            }
        }

        public IActionResult Index()
        {
            return View();
        }
        private bool UsuarioModelExists(string id)
        {
            return _context.Usuarios.Any(e => e.email == id);
        }

        // GET: LoginS
        public async Task<IActionResult> ListaDeUsuarios()
        {
            var teste = await _context.Usuarios.ToListAsync();
            return View("ListaDeUsuarios", teste);
        }
    }
}
    