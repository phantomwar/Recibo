﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using recibo.Data;

namespace recibo.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201002141500_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("recibo.Models.Recibo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DocumentoEmissor")
                        .HasColumnType("int");

                    b.Property<int>("DocumentoPagador")
                        .HasColumnType("int");

                    b.Property<int>("FormaPagamento")
                        .HasColumnType("int");

                    b.Property<string>("NomeEmissor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomePagador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TelefoneEmissor")
                        .HasColumnType("int");

                    b.Property<string>("cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("referente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Recibos");
                });
#pragma warning restore 612, 618
        }
    }
}
