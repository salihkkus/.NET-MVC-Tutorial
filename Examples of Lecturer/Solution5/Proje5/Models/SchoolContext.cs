using Microsoft.EntityFrameworkCore;    
using Proje5.Models;
using System.Collections.Generic;
 namespace Proje5.Models
namespace Proje5.Models
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        // Creates the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SchoolDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
