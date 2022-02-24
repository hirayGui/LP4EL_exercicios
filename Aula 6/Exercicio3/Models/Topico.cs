using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Topico
    {
        [Key]
        public int IdTopico { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPostagem { get; set; }
        public int IdAssunto { get; set; }
        [ForeignKey("IdAssunto")]
        public Assunto Assunto { get; set; }
    }
}