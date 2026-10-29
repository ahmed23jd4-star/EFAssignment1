using erfcore.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erfcore.context
{
    internal class dbReadMoreBookscontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=bookstore;trusted_connection=true;trustservercertificate=true");
        }
        public DbSet<book> Books { get; set; }  
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
