using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAuthorization.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>  options):base(options)
        {
            
        }
        public DbSet<Users> Kullanicilar { get; set; }
        public DbSet<Roles> Roller { get; set; }
        
    }
}