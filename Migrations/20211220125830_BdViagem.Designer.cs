﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneClick.Models;

#nullable disable

namespace OneClick.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211220125830_BdViagem")]
    partial class BdViagem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OneClick.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("CreditCard")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero_Voo")
                        .HasColumnType("int");

                    b.Property<int?>("ViagensId_Viagem")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ViagensId_Viagem");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("OneClick.Models.Viagens", b =>
                {
                    b.Property<int>("Id_Viagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Viagem"), 1L, 1);

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Viagem");

                    b.ToTable("Viagens");
                });

            modelBuilder.Entity("OneClick.Models.Clientes", b =>
                {
                    b.HasOne("OneClick.Models.Viagens", "Viagens")
                        .WithMany()
                        .HasForeignKey("ViagensId_Viagem");

                    b.Navigation("Viagens");
                });
#pragma warning restore 612, 618
        }
    }
}
