﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Universidade.Models
{
    public class Disciplina
    {
        [Key]
        public int IdDisciplina { get; set; }
        public string Descricao { get; set; }
        public int Creditos { get; set; }
        public int IdCurso { get; set; }
        [ForeignKey("IdCurso")]
        public Curso Curso { get; set; }

        public int IdProfessor { get; set; }
        [ForeignKey("IdProfessor")]
        public Professor Professor { get; set; }
    }
}