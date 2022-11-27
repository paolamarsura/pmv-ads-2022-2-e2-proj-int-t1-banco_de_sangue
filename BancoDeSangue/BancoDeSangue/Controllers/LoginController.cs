using BancoDeSangue.Data;
using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Controllers
{
    public class LoginController : AbstractController
    {

        private readonly BancoContext _context;

        public LoginController(BancoContext context, IUsuarioRepositorio usuarioRepo)
        {
            _context = context;
            _usuarioRepositorio = usuarioRepo;
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

            //definindo a sessão
            HttpContext.Session.SetString("userId", usuarioResposta.id.ToString());

            if (!usuarioResposta.senha.Equals(usuario.senha))
            {
                usuario.erro = "Usuário e senha inválido!";
                return View("Index", usuario);
            }
            
            if (usuarioResposta.perfil == "ADMIN")
            {
                return RedirectToAction("ListaDeUsuarios", "Login");
            }

            return RedirectToAction("Index", "Formulario");

        }

        public IActionResult Index()
        {
            HttpContext.Session.Remove("userId");
            var usuario = new UsuarioModel();
            return View(usuario);
        }
        
        public async Task<IActionResult> ListaDeUsuarios([FromQuery(Name = "sucesso")] string sucesso)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ListaUsuarioModel resultado = new ListaUsuarioModel();
            resultado.usuarios = await _context.Usuarios.ToListAsync();
            resultado.sucesso = sucesso;

            return View("ListaDeUsuarios", resultado);
        }
    }


}