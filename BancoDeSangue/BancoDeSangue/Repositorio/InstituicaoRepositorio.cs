using BancoDeSangue.Data;
using BancoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Repositorio
{
    public class InstituicaoRepositorio : IInstituicaoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public InstituicaoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public InstituicaoModel Adicionar(InstituicaoModel instituicao)
        {
            _bancoContext.Instituicoes.Add(instituicao);
            _bancoContext.SaveChanges();
            return instituicao;
        }

        public List<InstituicaoModel> BuscarTodos()
        {
            return _bancoContext.Instituicoes.ToList();
        }
    }
}
