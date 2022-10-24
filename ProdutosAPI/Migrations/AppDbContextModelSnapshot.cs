﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdutosAPI.Context;

namespace ProdutosAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProdutosAPI.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Midia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeMidia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Midias");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ComparacaoPreco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Categoria", b =>
                {
                    b.HasOne("ProdutosAPI.Models.Produto", "Produto")
                        .WithMany("Categorias")
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Midia", b =>
                {
                    b.HasOne("ProdutosAPI.Models.Produto", "Produto")
                        .WithMany("Midias")
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Tag", b =>
                {
                    b.HasOne("ProdutosAPI.Models.Produto", "Produto")
                        .WithMany("Tags")
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("ProdutosAPI.Models.Produto", b =>
                {
                    b.Navigation("Categorias");

                    b.Navigation("Midias");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}