using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ossmmasoft.RepositoryEFCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    UsuarioCreacion = table.Column<string>(type: "text", precision: 10, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioActualizacion = table.Column<string>(type: "text", precision: 10, nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CodigoEmpresa = table.Column<int>(type: "integer", precision: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreTitulos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreTitulos");
        }
    }
}
