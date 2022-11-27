using BancoDeSangue.Data;
using BancoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Repositorio
{
    public class FormularioRepositorio : IFormularioRepositorio
    {
        private readonly BancoContext _bancoContext;

        public FormularioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public FormularioModel Adicionar(FormularioModel formularioModel)
        {
            formularioModel.criacao = DateTime.Now;
            _bancoContext.Formulario.Add(formularioModel);
            _bancoContext.SaveChanges();
            return formularioModel;
        }

        public FormularioModel Atualizar(FormularioModel formularioModel)
        {
            formularioModel.criacao = DateTime.Now;
            _bancoContext.Formulario.Update(formularioModel);
            _bancoContext.SaveChanges();
            return formularioModel;
        }

        public FormularioModel BuscarFormularioPorUsuario(UsuarioModel usuario)
        {
            FormularioModel formulario = _bancoContext.Formulario.Where(x => x.usuarioId == usuario.id).FirstOrDefault();
            return formulario;
        }

        public FormularioModel BuscarFormulario(int id)
        {
            FormularioModel formulario = _bancoContext.Formulario.Where(x => x.id == id).FirstOrDefault();
            return formulario;
        }

        public List<FormularioModel> BuscarTodos()
        {
            return _bancoContext.Formulario.OrderByDescending(x => x.usuarioId).ToList();
        }
    }
}
