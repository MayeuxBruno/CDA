using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestEF.Data.Models;

namespace TestEF.Data
{
    public class MyDbContext:DbContext
    {
        public DbSet<Personne> Personnes { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options) 
        {

        }
    }
}
