using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blogezy.Models
{
    public class ArticleDbContext:DbContext
    {
        public ArticleDbContext():base("mydb")
        {

        }
        public DbSet<Article> Articles { get; set; }

        public DbSet<MainHeader> MainHeaders { get; set; }
    }
}