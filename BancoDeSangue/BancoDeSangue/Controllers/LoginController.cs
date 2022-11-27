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
            
            if (String.IsNullOrWhiteSpace(usuario.email) || String.IsNullOrWhiteSpace(usuario.senha)) {
                usuario.erro = "Preencha o Login e senha!";
                return View("Index", usuario);
            }

            usuario.SetSenhaHash(usuario);
            
            var email = usuario.email.Trim().ToLower();
            var usuarioResposta = _context.Usuarios.Where(x => x.email.Trim().ToLower().Equals(email)).FirstOrDefault();
            if (usuarioResposta == null)
            {
                usuario.erro = "Usuário não existe!";
                return View("Index", usuario);
            }            

            if (!usuarioResposta.senha.Equals(usuario.senha))
            {
                usuario.erro = "Usuário e senha inválido!";
                return View("Index", usuario);
            }

            if (String.IsNullOrWhiteSpace(usuarioResposta.perfil)) {
                return RedirectToAction("Index", "Formulario");
            }

            if (usuarioResposta.perfil.Equals("ADMIN"))
            {
                return RedirectToAction("ListaDeUsuarios", "Login");
            }

            usuario.erro = "Favor entrar em contato com o suporte técnico!";
            return View("Index", usuario);

        }

        public IActionResult Index()
        {
            var usuario = new UsuarioModel();
            return View(usuario);
        }
        
        public async Task<IActionResult> ListaDeUsuarios([FromQuery(Name = "sucesso")] string sucesso)
        {
            ListaUsuarioModel resultado = new ListaUsuarioModel();
            resultado.usuarios = await _context.Usuarios.ToListAsync();
            resultado.sucesso = sucesso;

            return View("ListaDeUsuarios", resultado);
        }
    }


}