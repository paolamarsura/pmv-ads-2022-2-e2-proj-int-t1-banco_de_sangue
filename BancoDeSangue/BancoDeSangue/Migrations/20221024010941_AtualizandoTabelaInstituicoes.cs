using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeSangue.Migrations
{
    public partial class AtualizandoTabelaInstituicoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instituicoes",
                table: "Instituicoes");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Instituicoes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Instituicoes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instituicoes",
                table: "Instituicoes",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instituicoes",
                table: "Instituicoes");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Instituicoes");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Instituicoes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instituicoes",
                table: "Instituicoes",
                column: "nome");
        }
    }
}
