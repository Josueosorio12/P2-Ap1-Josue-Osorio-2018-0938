using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_Ap1_Josue_Osorio_2018_0938.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoDeTarea",
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
                    table.PrimaryKey("PK_TipoDeTarea", x => x.Tipoid);
                });

            migrationBuilder.InsertData(
                table: "TipoDeTarea",
                columns: new[] { "Tipoid", "Requerimiento", "Tiempo", "TipodeTarea" },
                values: new object[] { 1, null, 0, "Analisis" });

            migrationBuilder.InsertData(
                table: "TipoDeTarea",
                columns: new[] { "Tipoid", "Requerimiento", "Tiempo", "TipodeTarea" },
                values: new object[] { 2, null, 0, "Diseno" });

            migrationBuilder.InsertData(
                table: "TipoDeTarea",
                columns: new[] { "Tipoid", "Requerimiento", "Tiempo", "TipodeTarea" },
                values: new object[] { 3, null, 0, "Programacion" });

            migrationBuilder.InsertData(
                table: "TipoDeTarea",
                columns: new[] { "Tipoid", "Requerimiento", "Tiempo", "TipodeTarea" },
                values: new object[] { 4, null, 0, "Prueba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoDeTarea");
        }
    }
}
