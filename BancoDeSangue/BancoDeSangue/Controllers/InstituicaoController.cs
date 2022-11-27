using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Controllers
{
    public class InstituicaoController : AbstractController     
    {
        private readonly IInstituicaoRepositorio _instituicaoRepositorio;
        private object _InstituicaoRepositorio;
        private object instituicao;

        public InstituicaoController(IInstituicaoRepositorio instituicaoRepositorio, IUsuarioRepositorio usuarioRepo)
        { 
            _instituicaoRepositorio = instituicaoRepositorio;
            _usuarioRepositorio = usuarioRepo;
        }

       
        public IActionResult Cadastrar()
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return View(new InstituicaoModel());
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            InstituicaoModel instituicao = _instituicaoRepositorio.BuscarInstituicao(id);
            if (instituicao == null)
            {
                return NotFound();
            }

            return View(instituicao);
        }

        [HttpPost]
        public IActionResult Editar(InstituicaoModel instituicao)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            if (String.IsNullOrWhiteSpace(instituicao.nome))
            {
                instituicao.erro = "Preencha o nome!";
                return View(instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.telefone))
            {
                instituicao.erro = "Preencha o Telefone!";
                return View(instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.endereco))
            {
                instituicao.erro = "Preencha o Endereço!";
                return View(instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.link))
            {
                instituicao.erro = "Preencha o Link do Google!";
                return View(instituicao);
            }

            _instituicaoRepositorio.Atualizar(instituicao);

            string sucesso = "A instituição " + instituicao.nome + " foi atualizada com sucesso!";
            return RedirectToAction("ListaDeInstituicao", "Instituicao", new { sucesso = sucesso });
        }


        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Apagar(int id)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            InstituicaoModel instituicao= _instituicaoRepositorio.BuscarInstituicao(id);
            if (instituicao == null)
            {
                return NotFound();
            }

            _instituicaoRepositorio.Remover(instituicao);
            string sucesso = "A instituição " + instituicao.nome + " foi removido com sucesso!";
            return RedirectToAction("ListaDeInstituicao", "Instituicao", new { sucesso = sucesso });
        }

        public IActionResult ListaDeInstituicao([FromQuery(Name = "sucesso")] string sucesso)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ListaInstituicaoModel resposta = new ListaInstituicaoModel();
            resposta.instituicoes = _instituicaoRepositorio.BuscarTodos();
            resposta.sucesso = sucesso;

            return View(resposta);
        }        

        [HttpPost]
        public IActionResult Cadastrar(InstituicaoModel instituicao)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            if (String.IsNullOrWhiteSpace(instituicao.nome))
            {
                instituicao.erro = "Preencha o nome!";
                return View(instituicao);
            }

            InstituicaoModel temNome = _instituicaoRepositorio.InstituicaoPorNome(instituicao.nome);
            if (temNome != null) {
                instituicao.erro = "Já existe esta intituição com nome de " + instituicao.nome + " !";
                return View(instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.telefone))
            {
                instituicao.erro = "Preencha o Telefone!";
                return View(instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.endereco))
            {
                instituicao.erro = "Preencha o Endereço!";
                return View(instituicao);
            }

            if (String.IsNullOrWhiteSpace(instituicao.link))
            {
                instituicao.erro = "Preencha o Link do Google!";
                return View(instituicao);
            }

            _instituicaoRepositorio.Adicionar(instituicao);

            string sucesso = "A instituição " + instituicao.nome + " foi salva com sucesso!";
            return RedirectToAction("ListaDeInstituicao", "Instituicao", new { sucesso = sucesso });
    
        }
     }
         
}
