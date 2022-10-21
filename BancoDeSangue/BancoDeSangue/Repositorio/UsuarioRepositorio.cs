using BancoDeSangue.Data;
using BancoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext; 

        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }   
      

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario; 
        }

      
    }
}
