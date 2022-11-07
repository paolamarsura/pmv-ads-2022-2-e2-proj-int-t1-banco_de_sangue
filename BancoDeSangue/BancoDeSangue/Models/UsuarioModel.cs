using BancoDeSangue.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Models
{
    public class UsuarioModel
    {
        [Key]
        public String email { get; set; }

        public String senha { get; set; }

        public String perfil { get; set; }

        public void SetSenhaHash(UsuarioModel usuario)
        {
            this.senha = usuario.senha.GerarHash();
        }
    }
}
