using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ossmmasoft.RepositoryEFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRE_DESCRIPTIVAS",
                columns: table => new
                {
                    DESCRIPCION_ID = table.Column<int>(type: "integer", nullable: false),
                    DESCRIPCION_FK_ID = table.Column<int>(type: "integer", nullable: false),
                    TITULO_ID = table.Column<int>(type: "integer", nullable: false),
                    DESCRIPCION = table.Column<string>(type: "text", nullable: true),
                    CODIGO = table.Column<string>(type: "text", nullable: true),
                    EXTRA1 = table.Column<string>(type: "text", nullable: true),
                    EXTRA2 = table.Column<string>(type: "text", nullable: true),
                    EXTRA3 = table.Column<string>(type: "text", nullable: true),
                    USUARIO_INS = table.Column<int>(type: "integer", nullable: true),
                    FECHA_INS = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_UPD = table.Column<int>(type: "integer", nullable: true),
                    FECHA_UPD = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CODIGO_EMPRESA = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRE_TITULOS",
                columns: table => new
                {
                    TITULO_ID = table.Column<int>(type: "integer", nullable: false),
                    TITULO_FK_ID = table.Column<int>(type: "integer", nullable: false),
                    TITULO = table.Column<string>(type: "text", nullable: true),
                    CODIGO = table.Column<string>(type: "text", nullable: true),
                    EXTRA1 = table.Column<string>(type: "text", nullable: true),
                    EXTRA2 = table.Column<string>(type: "text", nullable: true),
                    EXTRA3 = table.Column<string>(type: "text", nullable: true),
                    USUARIO_INS = table.Column<int>(type: "integer", nullable: true),
                    FECHA_INS = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    USUARIO_UPD = table.Column<int>(type: "integer", nullable: true),
                    FECHA_UPD = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CODIGO_EMPRESA = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PreTitulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", precision: 10, nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TituloPadreId = table.Column<int>(type: "integer", precision: 10, nullable: false),
                    Titulo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Codigo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Complemento1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Complemento2 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Complemento3 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UsuarioCreacion = table.Column<int>(type: "integer", precision: 10, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioActualizacion = table.Column<int>(type: "integer", precision: 10, nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CodigoEmpresa = table.Column<int>(type: "integer", precision: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreTitulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreDescriptiva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", precision: 10, nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DescripcionPadreId = table.Column<int>(type: "integer", precision: 10, nullable: true),
                    PreTituloId = table.Column<int>(type: "integer", precision: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Codigo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Complemento1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Complemento2 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Complemento3 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UsuarioCreacion = table.Column<int>(type: "integer", precision: 10, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UsuarioActualizacion = table.Column<int>(type: "integer", precision: 10, nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CodigoEmpresa = table.Column<int>(type: "integer", precision: 10, nullable: true),
                    Complemento4 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Complemento5 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreDescriptiva", x => x.Id);
                    table.ForeignKey(
                        name: "predescriptivas_fk",
                        column: x => x.PreTituloId,
                        principalTable: "PreTitulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreDescriptiva_PreTituloId",
                table: "PreDescriptiva",
                column: "PreTituloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRE_DESCRIPTIVAS");

            migrationBuilder.DropTable(
                name: "PRE_TITULOS");

            migrationBuilder.DropTable(
                name: "PreDescriptiva");

            migrationBuilder.DropTable(
                name: "PreTitulos");
        }
    }
}
