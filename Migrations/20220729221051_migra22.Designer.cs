﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolarEnergyBackEnd.Contextos;

#nullable disable

namespace SolarEnergyBackEnd.Migrations
{
    [DbContext(typeof(UnidadesContexto))]
    [Migration("20220729221051_migra22")]
    partial class migra22
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.6.22329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SolarEnergyBackEnd.Models.Producao", b =>
                {
                    b.Property<int>("IdProducao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducao"), 1L, 1);

                    b.Property<int?>("IdUnidade")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RegistradoEm")
                        .HasColumnType("datetime2");

                    b.Property<double?>("TotalGerado")
                        .HasColumnType("float");

                    b.Property<int?>("UnidadeProducaoIdUnidade")
                        .HasColumnType("int");

                    b.HasKey("IdProducao");

                    b.HasIndex("UnidadeProducaoIdUnidade");

                    b.ToTable("Producaos");
                });

            modelBuilder.Entity("SolarEnergyBackEnd.Models.Registro", b =>
                {
                    b.Property<int>("IdRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegistro"), 1L, 1);

                    b.Property<double>("Abril")
                        .HasColumnType("float");

                    b.Property<double>("Agosto")
                        .HasColumnType("float");

                    b.Property<double>("Dezembro")
                        .HasColumnType("float");

                    b.Property<double>("Fevereiro")
                        .HasColumnType("float");

                    b.Property<double>("Janeiro")
                        .HasColumnType("float");

                    b.Property<double>("Julho")
                        .HasColumnType("float");

                    b.Property<double>("Junho")
                        .HasColumnType("float");

                    b.Property<double>("Maio")
                        .HasColumnType("float");

                    b.Property<double>("Marco")
                        .HasColumnType("float");

                    b.Property<double>("Novembro")
                        .HasColumnType("float");

                    b.Property<double>("Outubro")
                        .HasColumnType("float");

                    b.Property<double>("Setembro")
                        .HasColumnType("float");

                    b.HasKey("IdRegistro");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("SolarEnergyBackEnd.Models.Unidade", b =>
                {
                    b.Property<int>("IdUnidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUnidade"), 1L, 1);

                    b.Property<bool?>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUnidade");

                    b.ToTable("Unidades");
                });

            modelBuilder.Entity("SolarEnergyBackEnd.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SolarEnergyBackEnd.Models.Producao", b =>
                {
                    b.HasOne("SolarEnergyBackEnd.Models.Unidade", "UnidadeProducao")
                        .WithMany("Producaos")
                        .HasForeignKey("UnidadeProducaoIdUnidade");

                    b.Navigation("UnidadeProducao");
                });

            modelBuilder.Entity("SolarEnergyBackEnd.Models.Unidade", b =>
                {
                    b.Navigation("Producaos");
                });
#pragma warning restore 612, 618
        }
    }
}
