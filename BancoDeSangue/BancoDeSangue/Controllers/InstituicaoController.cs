using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Controllers
{
    public class InstituicaoController : Controller     
    {
        private readonly IInstituicaoRepositorio _instituicaoRepositorio;

        public InstituicaoController(IInstituicaoRepositorio instituicaoRepositorio)
        { 
            _instituicaoRepositorio = instituicaoRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Cadastrar(InstituicaoModel instituicao)
        {
            _instituicaoRepositorio.Adicionar(instituicao);
            return RedirectToAction("Index", "Home");

        }
    }
         
}
