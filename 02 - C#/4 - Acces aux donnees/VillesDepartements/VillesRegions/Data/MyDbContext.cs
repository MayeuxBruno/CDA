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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departement>(e2 =>
            {
                e2.ToTable("departement");
                e2.Property(e => e.IdDepartement).HasColumnName("idDepartement");
            });

            modelBuilder.Entity<Ville>(e1 =>
            {
                e1.ToTable("ville");
                e1.Property(e => e.IdVille).HasColumnName("idVille");
                e1.HasOne(e => e.Dep).WithOne().HasForeignKey<Departement>(e => e.IdDepartement);
            });
        }
    }
}
