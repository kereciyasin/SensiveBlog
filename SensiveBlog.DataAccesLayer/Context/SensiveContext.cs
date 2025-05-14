using Microsoft.EntityFrameworkCore;
using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.DataAccesLayer.Context
{
    public class SensiveContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KERECI\\SQLEXPRESS;Database=SensiveBlogDb;Trusted_Connection=True;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
