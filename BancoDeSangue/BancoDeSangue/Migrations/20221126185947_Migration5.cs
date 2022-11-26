using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeSangue.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formulario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    peso = table.Column<float>(type: "real", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doacaoAnt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gravidez = table.Column<bool>(type: "bit", nullable: false),
                    amamentacao = table.Column<bool>(type: "bit", nullable: false),
                    gripe = table.Column<bool>(type: "bit", nullable: false),
                    tattoo = table.Column<bool>(type: "bit", nullable: false),
                    relacaoRisco = table.Column<bool>(type: "bit", nullable: false),
                    extracaoDent = table.Column<bool>(type: "bit", nullable: false),
                    cirurgia = table.Column<bool>(type: "bit", nullable: false),
                    acupuntura = table.Column<bool>(type: "bit", nullable: false),
                    vacina = table.Column<bool>(type: "bit", nullable: false),
                    herpes = table.Column<bool>(type: "bit", nullable: false),
                    malariaChagas = table.Column<bool>(type: "bit", nullable: false),
                    febreAmarela = table.Column<bool>(type: "bit", nullable: false),
                    covid = table.Column<bool>(type: "bit", nullable: false),
                    parkinson = table.Column<bool>(type: "bit", nullable: false),
                    hiv = table.Column<bool>(type: "bit", nullable: false),
                    hepatite = table.Column<bool>(type: "bit", nullable: false),
                    criacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    perfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    criacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formulario");

            migrationBuilder.DropTable(
                name: "Instituicoes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
