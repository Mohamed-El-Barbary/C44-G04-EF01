using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{
    internal class ITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .; database = ITIEF ; Trusted_Connection = true; TrustServerCertificate=True;");
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }
        //public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        //public DbSet<Course_Inst> Course_Inst { get; set; }
    }
}
