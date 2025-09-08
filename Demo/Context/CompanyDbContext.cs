using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Context
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {
            
        }

        // DbContext => Througth Overriding The OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .; database = CompantDbEF; trusted_connection = true;TrustServerCertificate = true");
        }

        public DbSet<Employee> Employees { get; set; }
        // When I Make Migration The Employee Become A Table In Db Has The Id and Name

    }
}
