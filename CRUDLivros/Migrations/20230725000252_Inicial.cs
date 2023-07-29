using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDLivros.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutorModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivroModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataPublicacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Editora = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivroModel_AutorModel_AutorId",
                        column: x => x.AutorId,
                        principalTable: "AutorModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivroModel_AutorId",
                table: "LivroModel",
                column: "AutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivroModel");

            migrationBuilder.DropTable(
                name: "AutorModel");
        }
    }
}
