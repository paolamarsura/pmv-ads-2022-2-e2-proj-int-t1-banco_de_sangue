using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BancoDeSangue.Controllers
{
    public class FormularioController : Controller
    {
        private readonly IFormularioRepositorio _formularioRepositorio;

        public FormularioController(IFormularioRepositorio formularioRepositorio)
        {
            _formularioRepositorio = formularioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Criar(FormularioModel formularioModel)
        {
            _formularioRepositorio.Adicionar(formularioModel);
            return RedirectToAction("Index", "InstituicoesEndereco");
        }

        public IActionResult Salvar()
        {
            return View();
        }

    }
}



    
