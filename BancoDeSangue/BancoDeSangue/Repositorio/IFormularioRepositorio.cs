using BancoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Repositorio
{
    public interface IFormularioRepositorio
    {
        FormularioModel Adicionar(FormularioModel formularioModel);
        FormularioModel Atualizar(FormularioModel formularioModel);
        FormularioModel BuscarFormularioPorUsuario(UsuarioModel usuario);
    }
}