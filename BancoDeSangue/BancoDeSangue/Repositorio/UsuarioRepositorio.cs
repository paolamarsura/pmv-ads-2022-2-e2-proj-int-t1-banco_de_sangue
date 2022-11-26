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
        public readonly String ADM = "ADMIN";

        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }

        public bool temADM()
        {            
            var usuarioResposta = _bancoContext.Usuarios.Where(x => x.perfil.Equals(ADM));
            return usuarioResposta != null;
        }

        public UsuarioModel CriarADM()
        {
            var usuario = new UsuarioModel();
            usuario.nome= "Administrador";
            usuario.email = "adm@adm.com";
            usuario.senha = "etapa2";
            usuario.perfil= ADM;
            usuario.criacao = DateTime.Now;

            usuario.SetSenhaHash(usuario);

            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            usuario.criacao = DateTime.Now;
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario; 
        }

      
    }
}
