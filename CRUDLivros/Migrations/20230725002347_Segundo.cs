using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDLivros.Migrations
{
    public partial class Segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LivroModel_AutorModel_AutorId",
                table: "LivroModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LivroModel",
                table: "LivroModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutorModel",
                table: "AutorModel");

            migrationBuilder.RenameTable(
                name: "LivroModel",
                newName: "Livros");

            migrationBuilder.RenameTable(
                name: "AutorModel",
                newName: "Autores");

            migrationBuilder.RenameIndex(
                name: "IX_LivroModel_AutorId",
                table: "Livros",
                newName: "IX_Livros_AutorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livros",
                table: "Livros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autores",
                table: "Autores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Livros",
                table: "Livros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autores",
                table: "Autores");

            migrationBuilder.RenameTable(
                name: "Livros",
                newName: "LivroModel");

            migrationBuilder.RenameTable(
                name: "Autores",
                newName: "AutorModel");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_AutorId",
                table: "LivroModel",
                newName: "IX_LivroModel_AutorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LivroModel",
                table: "LivroModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutorModel",
                table: "AutorModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LivroModel_AutorModel_AutorId",
                table: "LivroModel",
                column: "AutorId",
                principalTable: "AutorModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
