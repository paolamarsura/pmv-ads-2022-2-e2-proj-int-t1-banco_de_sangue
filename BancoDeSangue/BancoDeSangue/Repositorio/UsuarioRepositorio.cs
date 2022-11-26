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
            return _bancoContext.Usuarios.OrderBy(x => x.nome).ToList();
        }


        public UsuarioModel BuscarUsuario(int id)
        {
            UsuarioModel usuario = _bancoContext.Usuarios.Where(x => x.id == id).FirstOrDefault();
            return usuario;
        }

        public UsuarioModel BuscarUsuarioPorEmail(string email)
        {
            UsuarioModel usuario = _bancoContext.Usuarios.Where(x => x.email == email).FirstOrDefault();
            return usuario;
        }

        public void CriarADM()
        {
            var usuarioResposta = _bancoContext.Usuarios.Where(x => x.perfil.Equals(ADM)).FirstOrDefault();

            if (usuarioResposta == null) {
                var usuario = new UsuarioModel();
                usuario.nome = "Administrador";
                usuario.email = "adm@adm.com";
                usuario.senha = "etapa2";
                usuario.perfil = ADM;
                usuario.criacao = DateTime.Now;

                usuario.SetSenhaHash(usuario);

                _bancoContext.Usuarios.Add(usuario);
                _bancoContext.SaveChanges();
            }            
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            usuario.criacao = DateTime.Now;
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario; 
        }

        public void Remover(UsuarioModel usuario)
        {
            _bancoContext.Usuarios.Remove(usuario);
            _bancoContext.SaveChanges();            
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            _bancoContext.Usuarios.Update(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }


    }
}
