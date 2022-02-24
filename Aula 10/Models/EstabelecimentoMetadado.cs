using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio1.Models
{
    [MetadataType(typeof(EstabelecimentoMetadado))]
    public partial class Estabelecimento { }
    public class EstabelecimentoMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 15, ErrorMessage = "Este campo aceita apenas valores entre 0 e 15!")]
        public int IdEstabelecimento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Este campo deve conter entre 10 e 50 caracteres!")]
        public string NomeComercial { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [RegularExpression(@"^\d{2}.\d{3}.\d{3}/\d{4}-\d{2}$", ErrorMessage = "Formato de CNPJ inválido! Favor inserir todos os dígitos!")]
        public string CNPJ { get; set; } //XX. XXX. XXX/0001-XX

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Este campo deve conter entre 10 e 50 caracteres!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [RegularExpression(@"^(\d{2})\d{5}-\d{4}$", ErrorMessage ="Formato de telefone inválido!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Este campo deve conter entre 10 e 50 caracteres!")]
        public string PaginaWeb { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 15, ErrorMessage = "Este campo aceita apenas valores entre 0 e 15!")]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!", AllowEmptyStrings = false)]
        [Range(0, 10, ErrorMessage = "Este campo aceita apenas valores entre 0 e 10!")]
        public int IdCategoria { get; set; }
    }
}