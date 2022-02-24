using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Universidade.Models;

namespace Universidade.Models
{
    public class UniversidadeContexto : DbContext
    {
        public UniversidadeContexto() : base("name=UniversidadeContexto") { }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Professor> Professor { get; set; }
    }
}