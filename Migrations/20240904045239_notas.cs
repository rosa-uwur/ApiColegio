using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiColegio.Migrations
{
    /// <inheritdoc />
    public partial class notas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actividadesLibro = table.Column<int>(type: "int", nullable: false),
                    actividadesCuaderno = table.Column<int>(type: "int", nullable: false),
                    asistencia = table.Column<int>(type: "int", nullable: false),
                    examen = table.Column<int>(type: "int", nullable: false),
                    anio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas");
        }
    }
}
