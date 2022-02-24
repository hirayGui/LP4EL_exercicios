using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio1.Models
{
    [MetadataType(typeof(CategoriaMetadado))]
    public partial class Categoria { }
    public class CategoriaMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 10, ErrorMessage ="Este campo aceita apenas valores entre 0 e 10!")]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Este campo deve conter entre 5 e 50 caracteres!")]
        public string Descricao { get; set; }

    }
}