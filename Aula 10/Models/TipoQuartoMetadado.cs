using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio1.Models
{
    [MetadataType(typeof(TipoQuartoMetadado))]
    public partial class TipoQuarto { }
    public class TipoQuartoMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 10, ErrorMessage = "Este campo aceita apenas valores entre 0 e 10!")]
        public int IdTipoQuarto { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Este campo deve conter entre 10 e 50 caracteres!")]

        public string Descricao { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 10000, ErrorMessage = "Este campo aceita apenas valores entre 0 e 10000!")]
        public decimal ValorDiaria { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        public bool CafeManha { get; set; }
    }
}