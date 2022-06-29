using Microsoft.EntityFrameworkCore;
using StudentApplication.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.EF
{
    public class SMDbContext : DbContext
    {
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<Schools> Schools { get; set; }
        public DbSet<Studies> Studies { get; set; }

        public SMDbContext(DbContextOptions options) : base(options)
        {

        }

        public SMDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentManagment;Trusted_Connection=True;");
        }






    }
}
