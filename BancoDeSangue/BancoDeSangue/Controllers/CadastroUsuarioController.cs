using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Controllers
{
    public class CadastroUsuarioController : AbstractController
    {        

        public CadastroUsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio; 
        }

        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            List<UsuarioModel> usuario = _usuarioRepositorio.BuscarTodos();
            return View(usuario);
        }

        public IActionResult Criar()
        {
            var usuario = new UsuarioModel();
            return View(usuario);
        }
        
        [HttpGet]
        public IActionResult Editar(int id)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null) {
                return RedirectToAction("Index", "Login");
            }

            UsuarioModel usuario = _usuarioRepositorio.BuscarUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpGet]
        public IActionResult Perfil()
        {
            UsuarioModel usuarioLogado = this.usuarioLogado();

            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login", usuarioLogado);
            }

            return View("Editar", usuarioLogado);
        }

        

        [HttpPost]
        public IActionResult Editar(UsuarioModel usuario)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado();
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            if (String.IsNullOrWhiteSpace(usuario.nome))
            {
                usuario.erro = "Preencha o Nome!";
                return View("Criar", usuario);
            }

            if (String.IsNullOrWhiteSpace(usuario.email))
            {
                usuario.erro = "Preencha o Email!";
                return View("Criar", usuario);
            }

            UsuarioModel usuarioBD = _usuarioRepositorio.BuscarUsuario(usuario.id);
            if (usuarioBD == null)
            {
                return NotFound();
            }

            if (!String.IsNullOrWhiteSpace(usuario.senha))
            {
                usuarioBD.SetSenhaHash(usuario);
            }
            

            _usuarioRepositorio.CriarADM();


            usuarioBD.nome = usuario.nome;
            usuarioBD.email = usuario.email;

            _usuarioRepositorio.Atualizar(usuarioBD);
            usuarioBD.sucesso = "O usuário "  + usuarioBD.nome + " foi atualizado com sucesso!";
            return View(usuarioBD);
        }

        [HttpGet]
        public IActionResult Apagar(int id)
        {

            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            UsuarioModel usuarioBD = _usuarioRepositorio.BuscarUsuario(id);
            if (usuarioBD == null)
            {
                return NotFound();
            }

            _usuarioRepositorio.Remover(usuarioBD);
            string sucesso = "O usuário " + usuarioBD.nome + " foi removido com sucesso!";
            return RedirectToAction("ListaDeUsuarios", "Login", new { sucesso = sucesso });
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            if (String.IsNullOrWhiteSpace(usuario.email))
            {
                usuario.erro = "Preencha o Email!";
                return View("Criar", usuario);
            }

            var usuarioEmail = _usuarioRepositorio.BuscarUsuarioPorEmail(usuario.email);
            if (usuarioEmail != null) {
                usuario.erro = "Email já existe!";
                return View("Criar", usuario);
            }

            if (String.IsNullOrWhiteSpace(usuario.nome))
            {
                usuario.erro = "Preencha o Nome!";
                return View("Criar", usuario);
            }            

            if (String.IsNullOrWhiteSpace(usuario.senha))
            {
                usuario.erro = "Preencha a senha!";
                return View("Criar", usuario);
            }
            
            _usuarioRepositorio.CriarADM();            

            usuario.SetSenhaHash(usuario);
            UsuarioModel usuarioCriado = _usuarioRepositorio.Adicionar(usuario);
            HttpContext.Session.SetString("userId", usuarioCriado.id.ToString());

            return RedirectToAction("Index", "Formulario");
        }        
    }
}
