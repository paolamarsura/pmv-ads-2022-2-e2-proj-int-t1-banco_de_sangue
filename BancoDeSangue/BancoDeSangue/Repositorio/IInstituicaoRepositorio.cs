using BancoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Repositorio
{
    public interface IInstituicaoRepositorio
    {
        List<InstituicaoModel> BuscarTodos();
        InstituicaoModel Adicionar(InstituicaoModel instituicaoModel);
    }
}

