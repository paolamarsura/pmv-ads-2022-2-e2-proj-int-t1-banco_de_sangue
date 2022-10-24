using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeSangue.Migrations
{
    public partial class CriandoTabelaInstituicoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    nome = table.Column<string>(nullable: false),
                    cidade = table.Column<string>(nullable: true),
                    endereco = table.Column<string>(nullable: true),
                    telefone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.nome);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instituicoes");
        }
    }
}
