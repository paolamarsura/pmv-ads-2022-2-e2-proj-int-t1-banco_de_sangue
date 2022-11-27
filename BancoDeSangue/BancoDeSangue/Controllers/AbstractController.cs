using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangue.Controllers
{
    public abstract class AbstractController : Controller
    {

        protected IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioModel usuarioLogado(string perfil = null) {

            string userId = HttpContext.Session.GetString("userId");
            if (String.IsNullOrWhiteSpace(userId))
            {
                return null;
            }

            int id = int.Parse(userId);
            UsuarioModel usuario = _usuarioRepositorio.BuscarUsuario(id);
            

            if (perfil == "ADMIN") {
                if (usuario.perfil != perfil){
                    return null;
                }
            }

            if (usuario == null){
                return null;
            }

            ViewBag.perfil = usuario.perfil;

            return usuario;
        }
    }
}
