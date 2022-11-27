using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BancoDeSangue.Controllers
{
    public class FormularioController : AbstractController
    {
        private readonly IFormularioRepositorio _formularioRepositorio;

        public FormularioController(IFormularioRepositorio formularioRepositorio, IUsuarioRepositorio usuarioRepo)
        {
            _formularioRepositorio = formularioRepositorio;
            _usuarioRepositorio = usuarioRepo;
        }

        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = this.usuarioLogado();
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        [HttpPost]
        public IActionResult Criar(FormularioModel formularioModel)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado();
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            _formularioRepositorio.Adicionar(formularioModel);
            return RedirectToAction("Index", "InstituicoesEndereco");
        }

        public IActionResult Salvar()
        {
            return View();
        }

    }
}



    
