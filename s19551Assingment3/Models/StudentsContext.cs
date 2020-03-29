using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using s19551Assingment3.DAL;

namespace s19551Assingment3.Models
{
    public class StudentsContext:DbContext
    {
        public DbSet<Student> GetStudents { get; set; }
        public StudentsContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
        }

       
    }
}
