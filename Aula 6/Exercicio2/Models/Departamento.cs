
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Universidade.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string Descricao { get; set; }
        public ICollection<Curso> Curso { get; set; }
    }
}