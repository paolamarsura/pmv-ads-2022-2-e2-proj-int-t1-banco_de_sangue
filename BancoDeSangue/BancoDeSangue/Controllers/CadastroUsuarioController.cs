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
            return View();
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
            usuario.SetSenhaHash(usuario);
            _usuarioRepositorio.Adicionar(usuario);
            return RedirectToAction("Index", "Login");

            //Aqui ele redireciona para página index do Login
        }

        //Camada de negocios
    }
}
