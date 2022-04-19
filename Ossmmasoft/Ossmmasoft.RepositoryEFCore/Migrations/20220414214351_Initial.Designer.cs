﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Ossmmasoft.RepositoryEFCore.DataContext;

#nullable disable

namespace Ossmmasoft.RepositoryEFCore.Migrations
{
    [DbContext(typeof(OssmmasoftContext))]
    [Migration("20220414214351_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ossmmasoft.Entities.External.POCOs.PRE.PRE_DESCRIPTIVAS", b =>
                {
                    b.Property<string>("CODIGO")
                        .HasColumnType("text");

                    b.Property<int?>("CODIGO_EMPRESA")
                        .HasColumnType("integer");

                    b.Property<string>("DESCRIPCION")
                        .HasColumnType("text");

                    b.Property<int>("DESCRIPCION_FK_ID")
                        .HasColumnType("integer");

                    b.Property<int>("DESCRIPCION_ID")
                        .HasColumnType("integer");

                    b.Property<string>("EXTRA1")
                        .HasColumnType("text");

                    b.Property<string>("EXTRA2")
                        .HasColumnType("text");

                    b.Property<string>("EXTRA3")
                        .HasColumnType("text");

                    b.Property<DateTime?>("FECHA_INS")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("FECHA_UPD")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TITULO_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("USUARIO_INS")
                        .HasColumnType("integer");

                    b.Property<int?>("USUARIO_UPD")
                        .HasColumnType("integer");

                    b.ToTable("PRE_DESCRIPTIVAS");
                });

            modelBuilder.Entity("Ossmmasoft.Entities.External.POCOs.PRE.PRE_TITULOS", b =>
                {
                    b.Property<string>("CODIGO")
                        .HasColumnType("text");

                    b.Property<int?>("CODIGO_EMPRESA")
                        .HasColumnType("integer");

                    b.Property<string>("EXTRA1")
                        .HasColumnType("text");

                    b.Property<string>("EXTRA2")
                        .HasColumnType("text");

                    b.Property<string>("EXTRA3")
                        .HasColumnType("text");

                    b.Property<DateTime?>("FECHA_INS")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("FECHA_UPD")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TITULO")
                        .HasColumnType("text");

                    b.Property<int>("TITULO_FK_ID")
                        .HasColumnType("integer");

                    b.Property<int>("TITULO_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("USUARIO_INS")
                        .HasColumnType("integer");

                    b.Property<int?>("USUARIO_UPD")
                        .HasColumnType("integer");

                    b.ToTable("PRE_TITULOS");
                });

            modelBuilder.Entity("Ossmmasoft.Entities.Local.POCOs.PRE.PreDescriptiva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int?>("CodigoEmpresa")
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.Property<string>("Complemento1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Complemento2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Complemento3")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Complemento4")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Complemento5")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("DescripcionPadreId")
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("PreTituloId")
                        .IsRequired()
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.Property<int?>("UsuarioActualizacion")
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.Property<int?>("UsuarioCreacion")
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PreTituloId");

                    b.ToTable("PreDescriptiva");
                });

            modelBuilder.Entity("Ossmmasoft.Entities.Local.POCOs.PRE.PreTitulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int>("CodigoEmpresa")
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.Property<string>("Complemento1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Complemento2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Complemento3")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("TituloPadreId")
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioActualizacion")
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioCreacion")
                        .HasPrecision(10)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PreTitulos");
                });

            modelBuilder.Entity("Ossmmasoft.Entities.Local.POCOs.PRE.PreDescriptiva", b =>
                {
                    b.HasOne("Ossmmasoft.Entities.Local.POCOs.PRE.PreTitulo", "PreTitulo")
                        .WithMany("PreDescriptivas")
                        .HasForeignKey("PreTituloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("predescriptivas_fk");

                    b.Navigation("PreTitulo");
                });

            modelBuilder.Entity("Ossmmasoft.Entities.Local.POCOs.PRE.PreTitulo", b =>
                {
                    b.Navigation("PreDescriptivas");
                });
#pragma warning restore 612, 618
        }
    }
}
