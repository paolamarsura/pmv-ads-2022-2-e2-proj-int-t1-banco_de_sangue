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
        private object _InstituicaoRepositorio;
        private object instituicao;

        public InstituicaoController(IInstituicaoRepositorio instituicaoRepositorio)
        { 
            _instituicaoRepositorio = instituicaoRepositorio;
        }

       
        public IActionResult Cadastrar()
        {
            return View();
            
        }

         public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

        public IActionResult ListaDeInstituicao()
        {
            var teste = _instituicaoRepositorio.BuscarTodos();
            return View("ListaDeInstituicao", teste);
        }



        [HttpPost]
        public IActionResult Cadastrar(InstituicaoModel instituicao)
        {
            _instituicaoRepositorio.Adicionar(instituicao);
            return RedirectToAction("ListaDeInstituicao", "Instituicao");

        }

     }
         
}
