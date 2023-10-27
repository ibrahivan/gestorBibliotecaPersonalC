﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231027073216_migracioninicial2")]
    partial class migracioninicial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("DAL.Accesos", b =>
                {
                    b.Property<int>("id_acceso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_acceso");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id_acceso"));

                    b.Property<string>("codigo_acceso")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("codigo_acceso");

                    b.Property<string>("descripcion_acceso")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descripcion_acceso");

                    b.HasKey("id_acceso");

                    b.ToTable("accesos", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Autores", b =>
                {
                    b.Property<long>("id_autor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_autor");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_autor"));

                    b.Property<string>("apellidos_autor")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("apellidos_autor");

                    b.Property<string>("nombre_autor")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("nombre_autor");

                    b.HasKey("id_autor");

                    b.ToTable("autores", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Colecciones", b =>
                {
                    b.Property<long>("id_coleccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_coleccion");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_coleccion"));

                    b.Property<string>("nombre_coleccion")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("nombre_coleccion");

                    b.HasKey("id_coleccion");

                    b.ToTable("colecciones", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Editoriales", b =>
                {
                    b.Property<long>("id_editorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_editorial");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_editorial"));

                    b.Property<string>("nombre_editorial")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("nombre_editorial");

                    b.HasKey("id_editorial");

                    b.ToTable("rditoriales", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.EstadosPrestamos", b =>
                {
                    b.Property<long>("id_estado_prestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_estado_prestamo");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_estado_prestamo"));

                    b.Property<string>("codigo_estado_prestamo")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("codigo_estado_prestamo");

                    b.Property<string>("descripcion_estado_prestamo")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("descripcion_estado_prestamo");

                    b.HasKey("id_estado_prestamo");

                    b.ToTable("estadosPrestamos", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Generos", b =>
                {
                    b.Property<long>("id_genero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_genero");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_genero"));

                    b.Property<string>("descripcion_genero")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("descripcion_genero");

                    b.Property<string>("nombre_genero")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("nombre_genero");

                    b.HasKey("id_genero");

                    b.ToTable("generos", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Libros", b =>
                {
                    b.Property<long>("id_libro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_libro");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_libro"));

                    b.Property<int>("cantidad_libro")
                        .HasColumnType("int")
                        .HasColumnName("cantidad_libro");

                    b.Property<string>("edicion_libro")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("edicion_libro");

                    b.Property<long>("id_coleccion")
                        .HasColumnType("bigint");

                    b.Property<long>("id_editorial")
                        .HasColumnType("bigint");

                    b.Property<long>("id_genero")
                        .HasColumnType("bigint");

                    b.Property<string>("isbn_libro")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("isbn_libro");

                    b.Property<string>("titulo_libro")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("titulo_libro");

                    b.HasKey("id_libro");

                    b.HasIndex("id_coleccion");

                    b.HasIndex("id_editorial");

                    b.HasIndex("id_genero");

                    b.ToTable("libros", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Prestamos", b =>
                {
                    b.Property<long>("id_prestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_prestamo");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_prestamo"));

                    b.Property<DateTime>("fch_entrega_prestamo")
                        .HasColumnType("datetime")
                        .HasColumnName("fch_entrega_prestamo");

                    b.Property<DateTime>("fch_fin_prestamo")
                        .HasColumnType("datetime")
                        .HasColumnName("fch_fin_prestamo");

                    b.Property<DateTime>("fch_inicio_prestamo")
                        .HasColumnType("datetime")
                        .HasColumnName("fch_inicio_prestamo");

                    b.Property<long>("id_estado_prestamo")
                        .HasColumnType("bigint");

                    b.Property<long>("id_libro")
                        .HasColumnType("bigint");

                    b.Property<long>("id_usuario")
                        .HasColumnType("long");

                    b.HasKey("id_prestamo");

                    b.HasIndex("id_estado_prestamo");

                    b.HasIndex("id_libro");

                    b.HasIndex("id_usuario");

                    b.ToTable("prestamos", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.RelAutoresLibros", b =>
                {
                    b.Property<long>("id_rel_autores_libros")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_rel_autores_libros");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_rel_autores_libros"));

                    b.Property<long>("id_autor")
                        .HasColumnType("bigint");

                    b.Property<long>("id_libro")
                        .HasColumnType("bigint");

                    b.HasKey("id_rel_autores_libros");

                    b.HasIndex("id_autor");

                    b.HasIndex("id_libro");

                    b.ToTable("relAutoresLibros", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Usuarios", b =>
                {
                    b.Property<long>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("long")
                        .HasColumnName("id_usuario");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_usuario"));

                    b.Property<string>("apellidos_usuario")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("apellidos_usuario");

                    b.Property<string>("clave_usuario")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("clave_usuario");

                    b.Property<string>("dni_usuario")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("dni_usuario");

                    b.Property<string>("email_usuario")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("email_usuario");

                    b.Property<bool>("estaBloqueado_usuario")
                        .HasColumnType("bool")
                        .HasColumnName("estaBloqueado_usuario");

                    b.Property<DateTime>("fch_alta__usuario")
                        .HasColumnType("datetime")
                        .HasColumnName("fch_alta__usuario");

                    b.Property<DateTime>("fch_baja_usuario")
                        .HasColumnType("datetime")
                        .HasColumnName("fch_baja_usuario");

                    b.Property<DateTime>("fch_fin_bloqueo_usuario")
                        .HasColumnType("datetime")
                        .HasColumnName("fch_fin_bloqueo_usuario");

                    b.Property<int>("id_acceso")
                        .HasColumnType("int");

                    b.Property<string>("nombre_usuario")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("nombre_usuario");

                    b.Property<string>("tlf_usuario")
                        .IsRequired()
                        .HasColumnType("string")
                        .HasColumnName("tlf_usuario");

                    b.HasKey("id_usuario");

                    b.HasIndex("id_acceso");

                    b.ToTable("usuarios", "gbp_operacional");
                });

            modelBuilder.Entity("DAL.Libros", b =>
                {
                    b.HasOne("DAL.Colecciones", "coleccion")
                        .WithMany("librosColeccion")
                        .HasForeignKey("id_coleccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Editoriales", "editorial")
                        .WithMany("librosEditoriales")
                        .HasForeignKey("id_editorial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Generos", "genero")
                        .WithMany("librosGeneros")
                        .HasForeignKey("id_genero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("coleccion");

                    b.Navigation("editorial");

                    b.Navigation("genero");
                });

            modelBuilder.Entity("DAL.Prestamos", b =>
                {
                    b.HasOne("DAL.EstadosPrestamos", "estadoPrestamo")
                        .WithMany("prestamosEstado")
                        .HasForeignKey("id_estado_prestamo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Libros", "libro")
                        .WithMany("librosPrestamos")
                        .HasForeignKey("id_libro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Usuarios", "usuario")
                        .WithMany("usuariosConPrestamos")
                        .HasForeignKey("id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estadoPrestamo");

                    b.Navigation("libro");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("DAL.RelAutoresLibros", b =>
                {
                    b.HasOne("DAL.Autores", "autor")
                        .WithMany("autoresRelAutores")
                        .HasForeignKey("id_autor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Libros", "libro")
                        .WithMany("librosRelAutores")
                        .HasForeignKey("id_libro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("autor");

                    b.Navigation("libro");
                });

            modelBuilder.Entity("DAL.Usuarios", b =>
                {
                    b.HasOne("DAL.Accesos", "acceso")
                        .WithMany("usuariosConAcceso")
                        .HasForeignKey("id_acceso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("acceso");
                });

            modelBuilder.Entity("DAL.Accesos", b =>
                {
                    b.Navigation("usuariosConAcceso");
                });

            modelBuilder.Entity("DAL.Autores", b =>
                {
                    b.Navigation("autoresRelAutores");
                });

            modelBuilder.Entity("DAL.Colecciones", b =>
                {
                    b.Navigation("librosColeccion");
                });

            modelBuilder.Entity("DAL.Editoriales", b =>
                {
                    b.Navigation("librosEditoriales");
                });

            modelBuilder.Entity("DAL.EstadosPrestamos", b =>
                {
                    b.Navigation("prestamosEstado");
                });

            modelBuilder.Entity("DAL.Generos", b =>
                {
                    b.Navigation("librosGeneros");
                });

            modelBuilder.Entity("DAL.Libros", b =>
                {
                    b.Navigation("librosPrestamos");

                    b.Navigation("librosRelAutores");
                });

            modelBuilder.Entity("DAL.Usuarios", b =>
                {
                    b.Navigation("usuariosConPrestamos");
                });
#pragma warning restore 612, 618
        }
    }
}