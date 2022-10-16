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

    }
}
