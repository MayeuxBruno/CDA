using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace regions.Data.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Villes> Villes { get; set; }
        public DbSet<Departements> Departements { get; set; }
        public DbSet<Regions> Regions { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options):base (options)
        {

        }
    }
}
