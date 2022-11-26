using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace BancoDeSangue.Models
{
    public class ListaUsuarioModel
    {

        [NotMapped]
        public List<UsuarioModel> usuarios{ get; set; }

        [NotMapped]
        public String erro{ get; set; }

        [NotMapped]
        public String sucesso { get; set; }

    }
}
