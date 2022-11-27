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
        InstituicaoModel BuscarInstituicao(int id);

        InstituicaoModel Adicionar(InstituicaoModel instituicao);
        InstituicaoModel InstituicaoPorNome(string nome);

        InstituicaoModel Atualizar(InstituicaoModel instituicao);
        void Remover(InstituicaoModel instituicao);
    }
}

