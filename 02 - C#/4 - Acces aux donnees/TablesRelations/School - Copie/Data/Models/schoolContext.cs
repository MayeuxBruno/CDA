﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace School.Data.Models
{
    public partial class schoolContext : DbContext
    {
        public schoolContext()
        {
        }

        public schoolContext(DbContextOptions<schoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Studentscourse> Studentscourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("courses");

                entity.Property(e => e.CourseId).HasColumnType("int(11)");

                entity.Property(e => e.CourseName).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("grade");

                entity.Property(e => e.GradeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("GradeID");

                entity.Property(e => e.GradeName).HasMaxLength(100);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.HasIndex(e => e.GradeId, "GradeID");

                entity.Property(e => e.StudentId).HasColumnType("int(11)");

                entity.Property(e => e.GradeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("GradeID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Studentscourse>(entity =>
            {
                entity.HasKey(e => e.StudentCourseId)
                    .HasName("PRIMARY");

                entity.ToTable("studentscourses");

                entity.HasIndex(e => e.CourseId, "CourseId");

                entity.HasIndex(e => e.StudentId, "StudentId");

                entity.Property(e => e.StudentCourseId).HasColumnType("int(11)");

                entity.Property(e => e.CourseId).HasColumnType("int(11)");

                entity.Property(e => e.StudentId).HasColumnType("int(11)");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Studentscourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("studentscourses_ibfk_2");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Studentscourses)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("studentscourses_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
