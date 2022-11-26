using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BancoDeSangue.Models
{
    public class FormularioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public DateTime idade { get; set; }

        public float peso { get; set; }

        public String sexo { get; set; }

        public DateTime doacaoAnt { get; set; }

        public bool gravidez { get; set; }

        public bool amamentacao { get; set; }

        public bool gripe { get; set; }

        public bool tattoo { get; set; }

        public bool relacaoRisco { get; set; }

        public bool extracaoDent { get; set; }

        public bool cirurgia { get; set; }

        public bool acupuntura { get; set; }

        public bool vacina { get; set; }

        public bool herpes { get; set; }

        public bool malariaChagas { get; set; }

        public bool febreAmarela { get; set; }

        public bool covid { get; set; }

        public bool parkinson { get; set; }

        public bool hiv { get; set; }

        public bool hepatite { get; set; }

        public DateTime criacao { get; set; }

    }
}
