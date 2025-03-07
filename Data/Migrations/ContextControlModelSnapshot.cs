﻿// <auto-generated />
using System;
using ControleDeEstoqueProauto.Data;
using ControleDeEstoqueProauto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleDeEstoqueProauto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class ContextControlModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("ControleDeEstoqueProauto.Models.Movimentacoes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("IDSistema")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("movimentacoes");
                });

            modelBuilder.Entity("ControleDeEstoqueProauto.Models.Produtos", b =>
                {
                    b.Property<int>("IDSistema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstoqueMinimo")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDSistema");

                    b.ToTable("produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
