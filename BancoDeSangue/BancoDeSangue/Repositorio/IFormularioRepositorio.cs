using System.Collections.Generic;
using BancoDeSangue.Models;

namespace BancoDeSangue.Repositorio
{
    public interface IFormularioRepositorio
    {
        FormularioModel Adicionar(FormularioModel formularioModel);
        FormularioModel Atualizar(FormularioModel formularioModel);
        
        FormularioModel BuscarFormularioPorUsuario(UsuarioModel usuario);
        FormularioModel BuscarFormulario(int id);

        List<FormularioModel> BuscarTodos();
    }
}