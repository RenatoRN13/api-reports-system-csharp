﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ReportsSystemApi.Infra;

namespace ReportsSystemAPI.Migrations
{
    [DbContext(typeof(RSApiContext))]
    [Migration("20190903215825_RSApiMigration")]
    partial class RSApiMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ReportsSystemApi.Domain.Entities.Atividade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataFim");

                    b.Property<DateTime>("dataInicio");

                    b.Property<string>("descricao");

                    b.HasKey("id");

                    b.ToTable("Atividades");
                });

            modelBuilder.Entity("ReportsSystemApi.Domain.Entities.AtividadeUsuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("idAtividade");

                    b.Property<int>("idUsuario");

                    b.HasKey("id");

                    b.ToTable("AtividadeUsuarios");
                });

            modelBuilder.Entity("ReportsSystemApi.Domain.Entities.Log", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("acao");

                    b.Property<DateTime>("data");

                    b.Property<int>("idUsuario");

                    b.Property<string>("paginaAcessada");

                    b.HasKey("id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("ReportsSystemApi.Domain.Entities.Perfil", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao");

                    b.HasKey("id");

                    b.ToTable("Perfis");
                });

            modelBuilder.Entity("ReportsSystemApi.Domain.Entities.Relatorio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("conteudo");

                    b.Property<DateTime>("dataEnvio");

                    b.Property<string>("descricao");

                    b.Property<int>("idAtividade");

                    b.Property<int>("idUsuario");

                    b.Property<int>("nota");

                    b.HasKey("id");

                    b.ToTable("Relatorios");
                });

            modelBuilder.Entity("ReportsSystemApi.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("idPerfil");

                    b.Property<string>("login");

                    b.Property<string>("nome");

                    b.Property<string>("senha");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
