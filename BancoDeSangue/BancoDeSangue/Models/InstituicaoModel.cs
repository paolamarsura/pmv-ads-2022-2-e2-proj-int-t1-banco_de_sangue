using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangue.Models
{
    public class InstituicaoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public String nome { get; set; }
        
        public String cidade { get; set; }

        public String endereco { get; set; }

        public int telefone { get; set; }

        
    }
}
