using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class ForumContexto : DbContext
    {
        public ForumContexto() : base("name=ForumContexto") { }

        public DbSet<Assunto> Assunto { get; set; }
        public DbSet<Topico> Topico { get; set; }
    }
}