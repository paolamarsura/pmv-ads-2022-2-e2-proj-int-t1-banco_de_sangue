using BancoDeSangue.Helper;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BancoDeSangue.Models
{
    public class UsuarioModel
    {

        [Key]
        public int id{ get; set; }

        [Required]
        public String nome { get; set; }

        [Required]
        public String email { get; set; }

        [Required]
        public String senha { get; set; }

        public String perfil { get; set; }

        public DateTime criacao { get; set; }

        [NotMapped]
        public String erro{ get; set; }

        public void SetSenhaHash(UsuarioModel usuario)
        {
            this.senha = usuario.senha.GerarHash();
        }

        public void SetPerfil(UsuarioModel usuario)
        {
            if (usuario.perfil == null) {
                this.perfil = "USER";
            }            
        }
    }
}
