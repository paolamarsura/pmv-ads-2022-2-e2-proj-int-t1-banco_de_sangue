using System.Collections.Generic;
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

            ViewBag.viewMode = false;

            FormularioModel formulario = _formularioRepositorio.BuscarFormularioPorUsuario(usuarioLogado);
            return View(formulario);
        }

        [HttpGet]
        public IActionResult Visualizar(int id)
        {

            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }
            
            ViewBag.viewMode = true;

            FormularioModel formulario = _formularioRepositorio.BuscarFormulario(id);

            if (formulario == null) {
                return NotFound();
            }

            return View("Index", formulario);
        }

        public IActionResult Lista()
        {
            UsuarioModel usuarioLogado = this.usuarioLogado("ADMIN");
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }
            
            List<FormularioModel> formularios = _formularioRepositorio.BuscarTodos();

            foreach (FormularioModel formulario in formularios) {
                
                UsuarioModel usuario = _usuarioRepositorio.BuscarUsuario(formulario.usuarioId);
                if (usuario == null) {
                    continue;
                }

                formulario.usuarioNome = usuario.nome;
                formulario.usuarioEmail = usuario.email;

                formulario.apto = this.estaApto(formulario);

            }

            return View(formularios);
        }


        [HttpPost]
        public IActionResult Criar(FormularioModel formulario)
        {
            UsuarioModel usuarioLogado = this.usuarioLogado();
            if (usuarioLogado == null)
            {
                return RedirectToAction("Index", "Login");
            }

            string id = HttpContext.Session.GetString("userId");
            FormularioModel formularioBD = _formularioRepositorio.BuscarFormularioPorUsuario(usuarioLogado);

            formulario.usuarioId = int.Parse(id);

            if (formularioBD == null){
                _formularioRepositorio.Adicionar(formulario);
            }
            else {

                formularioBD.acupuntura = formulario.acupuntura;
                formularioBD.amamentacao = formulario.amamentacao;

                formularioBD.cirurgia = formulario.cirurgia;
                formularioBD.covid = formulario.covid;

                formularioBD.doacaoAnt = formulario.doacaoAnt;

                formularioBD.extracaoDent = formulario.extracaoDent;

                formularioBD.febreAmarela = formulario.febreAmarela;                

                formularioBD.gravidez = formulario.gravidez;
                formularioBD.gripe= formulario.gripe;

                formularioBD.hepatite = formulario.hepatite;
                formularioBD.herpes= formulario.herpes;                
                formularioBD.hiv = formulario.hiv;

                formularioBD.idade = formulario.idade;
                
                formularioBD.malariaChagas = formulario.malariaChagas;
                
                formularioBD.parkinson = formulario.parkinson;
                formularioBD.peso = formulario.peso;
                
                formularioBD.relacaoRisco = formulario.relacaoRisco;
                
                formularioBD.sexo = formulario.sexo;
                formularioBD.tattoo = formulario.tattoo;
                
                formularioBD.vacina = formulario.vacina;                

                _formularioRepositorio.Atualizar(formularioBD);                
            }

            return RedirectToAction("Index", "Formulario");
        }

        private bool estaApto(FormularioModel formulario) {
            return !(formulario.acupuntura || formulario.amamentacao || formulario.cirurgia || 
                formulario.covid || formulario.extracaoDent || formulario.febreAmarela || 
                formulario.gravidez || formulario.gripe || formulario.hepatite || formulario.herpes ||
                formulario.hiv || formulario.malariaChagas || formulario.parkinson || formulario.relacaoRisco || formulario.tattoo || formulario.vacina);
        }

    }
}



    
