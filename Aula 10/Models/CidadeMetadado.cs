using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio1.Models
{
    [MetadataType(typeof(CidadeMetadado))]
    public partial class Cidade { }
    public class CidadeMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 15, ErrorMessage = "Este campo aceita apenas valores entre 0 e 15!")]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(2, ErrorMessage ="Este campo aceita apenas 2 caracteres!")]
        public string UF { get; set; }

    }
}