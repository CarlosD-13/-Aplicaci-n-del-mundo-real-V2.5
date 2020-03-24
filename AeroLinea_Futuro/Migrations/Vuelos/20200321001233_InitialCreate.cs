using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AeroLinea_Futuro.Migrations.Vuelos
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vuelos",
                columns: table => new
                {
                    Id_Vuelos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Escala = table.Column<string>(type: "varchar(30)", nullable: false),
                    Tanda = table.Column<string>(type: "varchar(30)", nullable: false),
                    Categoria = table.Column<string>(type: "varchar(30)", nullable: false),
                    Fecha = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelos", x => x.Id_Vuelos);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vuelos");
        }
    }
}
