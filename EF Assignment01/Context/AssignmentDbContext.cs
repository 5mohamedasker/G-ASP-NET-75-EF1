using EF_Assignment01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment01.Context
{
    internal class AssignmentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server = .; Database = EFAssignment01; Trusted_Connection = True; TrustServerCertificate = True ");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Auther> Authers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
