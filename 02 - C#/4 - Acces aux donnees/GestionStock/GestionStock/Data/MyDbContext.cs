using System;
using GestionStock.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


#nullable disable

namespace GestionStock.Data
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Typesproduit> Typesproduits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;database=gestionstock;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.IdArticle)
                    .HasName("PRIMARY");

                entity.ToTable("articles");

                entity.HasIndex(e => e.IdCategorie, "FK_Categories_Articles");

                entity.Property(e => e.IdArticle)
                    .HasColumnType("int(11)")
                    .HasColumnName("idArticle");

                entity.Property(e => e.IdCategorie)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCategorie");

                entity.Property(e => e.LibelleArticle)
                    .HasMaxLength(100)
                    .HasColumnName("libelleArticle");

                entity.Property(e => e.QuantiteStockee)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantiteStockee");

                entity.HasOne(d => d.IdCategorieNavigation)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.IdCategorie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categories_Articles");
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.IdCategorie)
                    .HasName("PRIMARY");

                entity.ToTable("categories");

                entity.HasIndex(e => e.IdTypeProduit, "FK_Categories_TypesProduits");

                entity.Property(e => e.IdCategorie)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCategorie");

                entity.Property(e => e.IdTypeProduit)
                    .HasColumnType("int(11)")
                    .HasColumnName("idTypeProduit");

                entity.Property(e => e.LibelleCategorie)
                    .HasMaxLength(100)
                    .HasColumnName("libelleCategorie");

                entity.HasOne(d => d.IdTypeProduitNavigation)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.IdTypeProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categories_TypesProduits");
            });

            modelBuilder.Entity<Typesproduit>(entity =>
            {
                entity.HasKey(e => e.IdTypeProduit)
                    .HasName("PRIMARY");

                entity.ToTable("typesproduits");

                entity.Property(e => e.IdTypeProduit)
                    .HasColumnType("int(11)")
                    .HasColumnName("idTypeProduit");

                entity.Property(e => e.LibelleTypeProduit)
                    .HasMaxLength(100)
                    .HasColumnName("libelleTypeProduit");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
