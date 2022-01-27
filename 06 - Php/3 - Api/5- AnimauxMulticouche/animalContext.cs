﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AnimauxMulticouche.Data.Models
{
    public partial class animalContext : DbContext
    {
        public animalContext()
        {
        }

        public animalContext(DbContextOptions<animalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animauxes { get; set; }
        public virtual DbSet<Habitat> Habitats { get; set; }
        public virtual DbSet<Regimesalimentaire> Regimesalimentaires { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.HasKey(e => e.IdAnimal)
                    .HasName("PRIMARY");

                entity.ToTable("animaux");

                entity.HasIndex(e => e.IdHabitat, "FK_Animaux_Habitats");

                entity.HasIndex(e => e.IdRegimeAlimentaire, "FK_Animaux_RegimesAlimentaire");

                entity.Property(e => e.IdAnimal).HasColumnType("int(11)");

                entity.Property(e => e.IdHabitat).HasColumnType("int(11)");

                entity.Property(e => e.IdRegimeAlimentaire).HasColumnType("int(11)");

                entity.Property(e => e.NomAnimal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nomAnimal");

                entity.HasOne(d => d.IdHabitatNavigation)
                    .WithMany(p => p.Animauxes)
                    .HasForeignKey(d => d.IdHabitat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Animaux_Habitats");

                entity.HasOne(d => d.IdRegimeAlimentaireNavigation)
                    .WithMany(p => p.Animauxes)
                    .HasForeignKey(d => d.IdRegimeAlimentaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Animaux_RegimesAlimentaire");
            });

            modelBuilder.Entity<Habitat>(entity =>
            {
                entity.HasKey(e => e.IdHabitat)
                    .HasName("PRIMARY");

                entity.ToTable("habitats");

                entity.Property(e => e.IdHabitat).HasColumnType("int(11)");

                entity.Property(e => e.LibelleHabitat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("libelleHabitat");
            });

            modelBuilder.Entity<Regimesalimentaire>(entity =>
            {
                entity.HasKey(e => e.IdRegimeAlimentaire)
                    .HasName("PRIMARY");

                entity.ToTable("regimesalimentaire");

                entity.Property(e => e.IdRegimeAlimentaire).HasColumnType("int(11)");

                entity.Property(e => e.LibelleRegimeAlimentaire)
                    .HasMaxLength(50)
                    .HasColumnName("libelleRegimeAlimentaire");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
