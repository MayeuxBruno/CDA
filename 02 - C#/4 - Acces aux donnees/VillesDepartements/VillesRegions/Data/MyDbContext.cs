using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VillesRegions.Data.Models;

namespace VillesRegions.Data
{
    public class MyDbContext:DbContext
    {
        public DbSet<Departement> Departement { get; set; }
        public DbSet<Ville> Ville { get; set; }
        //public object Departements { get; internal set; }

        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }
    }
}
