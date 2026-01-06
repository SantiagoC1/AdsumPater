using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdsumPater.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitForo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intenciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: true),
                    Texto = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Fecha = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Rezos = table.Column<int>(type: "integer", nullable: false),
                    Estado = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intenciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reflexiones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Titulo = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Autor = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Contenido = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    Fecha = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reflexiones", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reflexiones",
                columns: new[] { "Id", "Autor", "Contenido", "Estado", "Fecha", "Titulo" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), "Equipo Adsum Pater", "Tomate un rato para silencio. Una oración breve y sincera abre camino.", 1, new DateTimeOffset(new DateTime(2026, 1, 3, 23, 24, 7, 872, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 0, 0, 0, 0)), "Semana Santa: volver al corazón" });

            migrationBuilder.CreateIndex(
                name: "IX_Intenciones_Estado",
                table: "Intenciones",
                column: "Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Intenciones_Fecha",
                table: "Intenciones",
                column: "Fecha");

            migrationBuilder.CreateIndex(
                name: "IX_Reflexiones_Estado",
                table: "Reflexiones",
                column: "Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Reflexiones_Fecha",
                table: "Reflexiones",
                column: "Fecha");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intenciones");

            migrationBuilder.DropTable(
                name: "Reflexiones");
        }
    }
}
