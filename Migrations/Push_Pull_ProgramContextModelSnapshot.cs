﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Push_Pull_Program.Data;

#nullable disable

namespace Push_Pull_Program.Migrations
{
    [DbContext(typeof(Push_Pull_ProgramContext))]
    partial class Push_Pull_ProgramContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Push_Pull_Program.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sexo")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("Push_Pull_Program.Models.EmpleadoReporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int>("ReporteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("ReporteId");

                    b.ToTable("EmpleadoReporte");
                });

            modelBuilder.Entity("Push_Pull_Program.Models.Reporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Transmision")
                        .HasColumnType("datetime2");

                    b.Property<string>("RNC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reporte");
                });

            modelBuilder.Entity("Push_Pull_Program.Models.EmpleadoReporte", b =>
                {
                    b.HasOne("Push_Pull_Program.Models.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("Push_Pull_Program.Models.Reporte", "Reporte")
                        .WithMany()
                        .HasForeignKey("ReporteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Reporte");
                });
#pragma warning restore 612, 618
        }
    }
}