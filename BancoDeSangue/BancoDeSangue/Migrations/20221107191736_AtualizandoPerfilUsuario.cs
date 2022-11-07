using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeSangue.Migrations
{
    public partial class AtualizandoPerfilUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "perfil",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "perfil",
                table: "Usuarios");
        }
    }
}
