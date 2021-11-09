using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_Ap1_Josue_Osorio_2018_0938.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    Proyectoid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Total = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.Proyectoid);
                });

            migrationBuilder.CreateTable(
                name: "TipoTarea",
                columns: table => new
                {
                    Tipoid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipodeTarea = table.Column<string>(type: "TEXT", nullable: true),
                    Requerimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarea", x => x.Tipoid);
                });

            migrationBuilder.CreateTable(
                name: "TipoDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Proyectoid = table.Column<int>(type: "INTEGER", nullable: false),
                    TipodeTarea = table.Column<string>(type: "TEXT", nullable: true),
                    Requerimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoDetalle_Proyectos_Proyectoid",
                        column: x => x.Proyectoid,
                        principalTable: "Proyectos",
                        principalColumn: "Proyectoid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "Tipoid", "Requerimiento", "Tiempo", "TipodeTarea" },
                values: new object[] { 1, null, 0, "Analisis" });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "Tipoid", "Requerimiento", "Tiempo", "TipodeTarea" },
                values: new object[] { 2, null, 0, "Diseno" });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "Tipoid", "Requerimiento", "Tiempo", "TipodeTarea" },
                values: new object[] { 3, null, 0, "Programacion" });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "Tipoid", "Requerimiento", "Tiempo", "TipodeTarea" },
                values: new object[] { 4, null, 0, "Prueba" });

            migrationBuilder.CreateIndex(
                name: "IX_TipoDetalle_Proyectoid",
                table: "TipoDetalle",
                column: "Proyectoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoDetalle");

            migrationBuilder.DropTable(
                name: "TipoTarea");

            migrationBuilder.DropTable(
                name: "Proyectos");
        }
    }
}
