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
            return View(new InstituicaoModel());            
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

        public IActionResult ListaDeInstituicao([FromQuery(Name = "sucesso")] string sucesso)
        {

            ListaInstituicaoModel resposta = new ListaInstituicaoModel();
            resposta.instituicoes = _instituicaoRepositorio.BuscarTodos();
            resposta.sucesso = sucesso;

            return View(resposta);
        }

        [HttpGet]
        public IActionResult InstituicoesEndereco([FromQuery(Name = "sucesso")] string sucesso)
        {

            ListaInstituicaoModel resposta = new ListaInstituicaoModel();
            resposta.instituicoes = _instituicaoRepositorio.BuscarTodos();
            resposta.sucesso = sucesso;

            return View("InstituicoesEndereco", resposta);
        }
        

        [HttpPost]
        public IActionResult Cadastrar(InstituicaoModel instituicao)
        {
            if (String.IsNullOrWhiteSpace(instituicao.nome))
            {
                instituicao.erro = "Preencha o nome!";
                return View("Cadastrar", instituicao);
            }

            InstituicaoModel temNome = _instituicaoRepositorio.InstituicaoPorNome(instituicao.nome);
            if (temNome != null) {
                instituicao.erro = "Já existe esta intituição com nome de " + instituicao.nome + " !";
                return View("Cadastrar", instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.telefone))
            {
                instituicao.erro = "Preencha o Telefone!";
                return View("Cadastrar", instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.endereco))
            {
                instituicao.erro = "Preencha o Endereço!";
                return View("Cadastrar", instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.link))
            {
                instituicao.erro = "Preencha o Link do Google!";
                return View("Cadastrar", instituicao);
            }

            _instituicaoRepositorio.Adicionar(instituicao);

            string sucesso = "A instituição " + instituicao.nome + " foi salva com sucesso!";
            return RedirectToAction("ListaDeInstituicao", "Instituicao", new { sucesso = sucesso });
    
        }
     }
         
}
