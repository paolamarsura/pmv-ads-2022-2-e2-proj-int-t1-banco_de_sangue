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
            instituicao.criacao = DateTime.Now;
            _bancoContext.Instituicoes.Add(instituicao);
            _bancoContext.SaveChanges();
            return instituicao;
        }        

        public InstituicaoModel InstituicaoPorNome(string nome)
        {
            nome = nome.Trim().ToLower();
            InstituicaoModel instituicao = _bancoContext.Instituicoes.Where(x => x.nome.Trim().ToLower().Equals(nome)).FirstOrDefault();
            return instituicao;
        }

        public List<InstituicaoModel> BuscarTodos()
        {
            return _bancoContext.Instituicoes.ToList();
        }

        public InstituicaoModel BuscarInstituicao(int id)
        {
            InstituicaoModel instituicao = _bancoContext.Instituicoes.Where(x => x.id == id).FirstOrDefault();
            return instituicao;
        }

        public InstituicaoModel Atualizar(InstituicaoModel instituicao)
        {
            _bancoContext.Instituicoes.Update(instituicao);
            _bancoContext.SaveChanges();
            return instituicao;
        }


        public void Remover(InstituicaoModel instituicao)
        {
            _bancoContext.Instituicoes.Remove(instituicao);
            _bancoContext.SaveChanges();
        }
    }
}
