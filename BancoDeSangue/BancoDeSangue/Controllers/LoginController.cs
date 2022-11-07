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
        public IActionResult Login(UsuarioModel usuario)
        {
            usuario.SetSenhaHash(usuario);
            //var teste = _context.Usuarios.Where(x => x.email.Equals(usuario.email) && x.senha.Equals(usuario.senha)).FirstOrDefault();
            var usuarioResposta = _context.Usuarios.Where(x => x.email.Equals(usuario.email)).FirstOrDefault();

            if (usuarioResposta != null && usuarioResposta.email.Equals(usuario.email) && usuarioResposta.senha.Equals(usuario.senha))
            {
                if (usuarioResposta.perfil.Equals("ADMIN"))
                {
                    return RedirectToAction("ListaDeUsuarios", "Login");
                }
                else
                {
                    return RedirectToAction("Privacy", "Home");
                }
            }
            else
            {
                return RedirectToAction("Privacy", "Home");
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