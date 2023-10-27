using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class migracioninicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "gbp_operacional");

            migrationBuilder.CreateTable(
                name: "accesos",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_acceso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    codigo_acceso = table.Column<string>(type: "text", nullable: false),
                    descripcion_acceso = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accesos", x => x.id_acceso);
                });

            migrationBuilder.CreateTable(
                name: "autores",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_autor = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_autor = table.Column<string>(type: "string", nullable: false),
                    apellidos_autor = table.Column<string>(type: "string", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.id_autor);
                });

            migrationBuilder.CreateTable(
                name: "colecciones",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_coleccion = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_coleccion = table.Column<string>(type: "string", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colecciones", x => x.id_coleccion);
                });

            migrationBuilder.CreateTable(
                name: "estadosPrestamos",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_estado_prestamo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    codigo_estado_prestamo = table.Column<string>(type: "string", nullable: false),
                    descripcion_estado_prestamo = table.Column<string>(type: "string", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadosPrestamos", x => x.id_estado_prestamo);
                });

            migrationBuilder.CreateTable(
                name: "generos",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_genero = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_genero = table.Column<string>(type: "string", nullable: false),
                    descripcion_genero = table.Column<string>(type: "string", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.id_genero);
                });

            migrationBuilder.CreateTable(
                name: "rditoriales",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_editorial = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_editorial = table.Column<string>(type: "string", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rditoriales", x => x.id_editorial);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_usuario = table.Column<long>(type: "long", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dni_usuario = table.Column<string>(type: "string", nullable: false),
                    nombre_usuario = table.Column<string>(type: "string", nullable: false),
                    apellidos_usuario = table.Column<string>(type: "string", nullable: false),
                    tlf_usuario = table.Column<string>(type: "string", nullable: false),
                    email_usuario = table.Column<string>(type: "string", nullable: false),
                    clave_usuario = table.Column<string>(type: "string", nullable: false),
                    estaBloqueado_usuario = table.Column<bool>(type: "bool", nullable: false),
                    fch_fin_bloqueo_usuario = table.Column<DateTime>(type: "datetime", nullable: false),
                    fch_alta__usuario = table.Column<DateTime>(type: "datetime", nullable: false),
                    fch_baja_usuario = table.Column<DateTime>(type: "datetime", nullable: false),
                    id_acceso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id_usuario);
                    table.ForeignKey(
                        name: "FK_usuarios_accesos_id_acceso",
                        column: x => x.id_acceso,
                        principalSchema: "gbp_operacional",
                        principalTable: "accesos",
                        principalColumn: "id_acceso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "libros",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_libro = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    isbn_libro = table.Column<string>(type: "string", nullable: false),
                    titulo_libro = table.Column<string>(type: "string", nullable: false),
                    edicion_libro = table.Column<string>(type: "string", nullable: false),
                    cantidad_libro = table.Column<int>(type: "int", nullable: false),
                    id_editorial = table.Column<long>(type: "bigint", nullable: false),
                    id_genero = table.Column<long>(type: "bigint", nullable: false),
                    id_coleccion = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.id_libro);
                    table.ForeignKey(
                        name: "FK_libros_colecciones_id_coleccion",
                        column: x => x.id_coleccion,
                        principalSchema: "gbp_operacional",
                        principalTable: "colecciones",
                        principalColumn: "id_coleccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_libros_generos_id_genero",
                        column: x => x.id_genero,
                        principalSchema: "gbp_operacional",
                        principalTable: "generos",
                        principalColumn: "id_genero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_libros_rditoriales_id_editorial",
                        column: x => x.id_editorial,
                        principalSchema: "gbp_operacional",
                        principalTable: "rditoriales",
                        principalColumn: "id_editorial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prestamos",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_prestamo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    id_usuario = table.Column<long>(type: "long", nullable: false),
                    id_libro = table.Column<long>(type: "bigint", nullable: false),
                    fch_inicio_prestamo = table.Column<DateTime>(type: "datetime", nullable: false),
                    fch_fin_prestamo = table.Column<DateTime>(type: "datetime", nullable: false),
                    fch_entrega_prestamo = table.Column<DateTime>(type: "datetime", nullable: false),
                    id_estado_prestamo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamos", x => x.id_prestamo);
                    table.ForeignKey(
                        name: "FK_prestamos_estadosPrestamos_id_estado_prestamo",
                        column: x => x.id_estado_prestamo,
                        principalSchema: "gbp_operacional",
                        principalTable: "estadosPrestamos",
                        principalColumn: "id_estado_prestamo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prestamos_libros_id_libro",
                        column: x => x.id_libro,
                        principalSchema: "gbp_operacional",
                        principalTable: "libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prestamos_usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalSchema: "gbp_operacional",
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "relAutoresLibros",
                schema: "gbp_operacional",
                columns: table => new
                {
                    id_rel_autores_libros = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    id_autor = table.Column<long>(type: "bigint", nullable: false),
                    id_libro = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relAutoresLibros", x => x.id_rel_autores_libros);
                    table.ForeignKey(
                        name: "FK_relAutoresLibros_autores_id_autor",
                        column: x => x.id_autor,
                        principalSchema: "gbp_operacional",
                        principalTable: "autores",
                        principalColumn: "id_autor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_relAutoresLibros_libros_id_libro",
                        column: x => x.id_libro,
                        principalSchema: "gbp_operacional",
                        principalTable: "libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_coleccion",
                schema: "gbp_operacional",
                table: "libros",
                column: "id_coleccion");

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_editorial",
                schema: "gbp_operacional",
                table: "libros",
                column: "id_editorial");

            migrationBuilder.CreateIndex(
                name: "IX_libros_id_genero",
                schema: "gbp_operacional",
                table: "libros",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_id_estado_prestamo",
                schema: "gbp_operacional",
                table: "prestamos",
                column: "id_estado_prestamo");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_id_libro",
                schema: "gbp_operacional",
                table: "prestamos",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_id_usuario",
                schema: "gbp_operacional",
                table: "prestamos",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_relAutoresLibros_id_autor",
                schema: "gbp_operacional",
                table: "relAutoresLibros",
                column: "id_autor");

            migrationBuilder.CreateIndex(
                name: "IX_relAutoresLibros_id_libro",
                schema: "gbp_operacional",
                table: "relAutoresLibros",
                column: "id_libro");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_id_acceso",
                schema: "gbp_operacional",
                table: "usuarios",
                column: "id_acceso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prestamos",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "relAutoresLibros",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "estadosPrestamos",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "usuarios",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "autores",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "libros",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "accesos",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "colecciones",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "generos",
                schema: "gbp_operacional");

            migrationBuilder.DropTable(
                name: "rditoriales",
                schema: "gbp_operacional");
        }
    }
}
