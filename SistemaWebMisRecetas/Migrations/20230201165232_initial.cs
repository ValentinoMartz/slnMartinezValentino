using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "varchar(8)", nullable: false),
                    Ingredientes = table.Column<string>(type: "varchar(150)", nullable: false),
                    Instrucciones = table.Column<string>(type: "varchar(500)", nullable: false),
                    Autor = table.Column<string>(type: "varchar(40)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(40)", nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receta");
        }
    }
}
