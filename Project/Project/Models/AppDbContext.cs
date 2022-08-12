using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
        public DbSet<Contacting> contact { get; set; }
        public DbSet<information> information { get; set; }
        public DbSet<newsLetters> newsLetters { get; set; }
        public DbSet<Job_App> Apps { get; set; }
    }
}
