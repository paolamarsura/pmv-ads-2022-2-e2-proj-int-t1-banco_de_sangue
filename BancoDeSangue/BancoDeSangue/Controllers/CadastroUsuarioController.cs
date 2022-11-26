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

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
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

            if (String.IsNullOrWhiteSpace(usuario.senha))
            {
                usuario.erro = "Preencha a senha!";
                return View("Criar", usuario);
            }

            if (_usuarioRepositorio.temADM()) {
                _usuarioRepositorio.CriarADM();
            }

            usuario.SetSenhaHash(usuario);
            _usuarioRepositorio.Adicionar(usuario);

            return RedirectToAction("Index", "Formulario");         
        }        
    }
}
