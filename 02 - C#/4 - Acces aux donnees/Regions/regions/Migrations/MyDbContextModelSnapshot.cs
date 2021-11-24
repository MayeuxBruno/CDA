﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using regions.Data;

namespace regions.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("regions.Data.Departements", b =>
                {
                    b.Property<int>("IdDepartement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomDepartement")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("RegionsIdRegion")
                        .HasColumnType("int");

                    b.HasKey("IdDepartement");

                    b.HasIndex("RegionsIdRegion");

                    b.ToTable("Depatements");
                });

            modelBuilder.Entity("regions.Data.Regions", b =>
                {
                    b.Property<int>("IdRegion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomRegion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdRegion");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("regions.Data.Villes", b =>
                {
                    b.Property<int>("IdVille")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DepartementsIdDepartement")
                        .HasColumnType("int");

                    b.Property<string>("NomVille")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdVille");

                    b.HasIndex("DepartementsIdDepartement");

                    b.ToTable("Villes");
                });

            modelBuilder.Entity("regions.Data.Departements", b =>
                {
                    b.HasOne("regions.Data.Regions", null)
                        .WithMany("ListeDepartements")
                        .HasForeignKey("RegionsIdRegion");
                });

            modelBuilder.Entity("regions.Data.Villes", b =>
                {
                    b.HasOne("regions.Data.Departements", null)
                        .WithMany("ListeVilles")
                        .HasForeignKey("DepartementsIdDepartement");
                });

            modelBuilder.Entity("regions.Data.Departements", b =>
                {
                    b.Navigation("ListeVilles");
                });

            modelBuilder.Entity("regions.Data.Regions", b =>
                {
                    b.Navigation("ListeDepartements");
                });
#pragma warning restore 612, 618
        }
    }
}
