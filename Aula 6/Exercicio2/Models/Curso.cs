
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Universidade.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public string Descricao { get; set; }
        public ICollection<Disciplina> Disciplina { get; set; }

        public int IdDepartamento { get; set; }
        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }
    }
}