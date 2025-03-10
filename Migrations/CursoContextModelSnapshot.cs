﻿// <auto-generated />
using System;
using Cursosufc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cursosufc.Migrations
{
    [DbContext(typeof(CursoContext))]
    partial class CursoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Cursosufc.Models.CursoModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Duracao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Modalidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });
#pragma warning restore 612, 618
        }
    }
}
