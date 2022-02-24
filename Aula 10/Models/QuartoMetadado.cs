using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio1.Models
{
    [MetadataType(typeof(QuartoMetadado))]
    public partial class Quarto { }
    public class QuartoMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 10, ErrorMessage = "Este campo aceita apenas valores entre 0 e 10!")]
        public int IdQuarto { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 500, ErrorMessage = "Este campo aceita apenas valores entre 0 e 500!")]
        [Remote("VerificaSeQuartoNaoExiste", "Quarto", AdditionalFields ="IdEstabelecimento", ErrorMessage = "Este número de quarto já existe!")]
        public int NumeroQuarto { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        public bool Disponivel { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 15, ErrorMessage = "Este campo aceita apenas valores entre 0 e 15!")]
        public int IdEstabelecimento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 10, ErrorMessage = "Este campo aceita apenas valores entre 0 e 10!")]
        public int IdTipoQuarto { get; set; }
    }
}