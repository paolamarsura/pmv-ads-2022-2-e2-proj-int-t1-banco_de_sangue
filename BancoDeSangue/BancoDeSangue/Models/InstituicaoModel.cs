using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoDeSangue.Models
{
    public class InstituicaoModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public String nome { get; set; }

        [Required]
        public String telefone{ get; set; }

        [Required]
        public String endereco { get; set; }

        [Required]
        public String link{ get; set; }

        public DateTime criacao { get; set; }

        [NotMapped]
        public String erro{ get; set; }


    }
}
