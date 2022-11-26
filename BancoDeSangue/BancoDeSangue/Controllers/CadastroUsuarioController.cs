using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Controllers
{
    public class CadastroUsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public CadastroUsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio; 
        }

        public IActionResult Index()
        {
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
            UsuarioModel usuario = _usuarioRepositorio.BuscarUsuario(id);
            if (usuario == null) {
                return NotFound();
            }
            
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(UsuarioModel usuario)
        {
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

        public IActionResult Apagar()
        {
            return View();
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
            _usuarioRepositorio.Adicionar(usuario);

            return RedirectToAction("Index", "Formulario");
        }        
    }
}
