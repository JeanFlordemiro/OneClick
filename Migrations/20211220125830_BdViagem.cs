using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneClick.Migrations
{
    public partial class BdViagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Viagens",
                columns: table => new
                {
                    Id_Viagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagens", x => x.Id_Viagem);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_Voo = table.Column<int>(type: "int", nullable: false),
                    ViagensId_Viagem = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<int>(type: "int", nullable: false),
                    CreditCard = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Viagens_ViagensId_Viagem",
                        column: x => x.ViagensId_Viagem,
                        principalTable: "Viagens",
                        principalColumn: "Id_Viagem");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ViagensId_Viagem",
                table: "Clientes",
                column: "ViagensId_Viagem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Viagens");
        }
    }
}
