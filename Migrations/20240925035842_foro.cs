using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiColegio.Migrations
{
    /// <inheritdoc />
    public partial class foro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    autorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foros_Maestros_autorId",
                        column: x => x.autorId,
                        principalTable: "Maestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaComentario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    autorId = table.Column<int>(type: "int", nullable: false),
                    foroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentario_Foros_foroId",
                        column: x => x.foroId,
                        principalTable: "Foros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentario_Maestros_autorId",
                        column: x => x.autorId,
                        principalTable: "Maestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_autorId",
                table: "Comentario",
                column: "autorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_foroId",
                table: "Comentario",
                column: "foroId");

            migrationBuilder.CreateIndex(
                name: "IX_Foros_autorId",
                table: "Foros",
                column: "autorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Foros");
        }
    }
}
