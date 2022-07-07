using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.EF

{
    public class SMDbContextFactory : IDesignTimeDbContextFactory<SMDbContext>
    {
        public SMDbContext CreateDbContext(string[] args=null)
        {
            var options = new DbContextOptionsBuilder<SMDbContext>();

            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentManagment;Trusted_Connection=True;");

            return new SMDbContext(options.Options);
        }
    }
}
