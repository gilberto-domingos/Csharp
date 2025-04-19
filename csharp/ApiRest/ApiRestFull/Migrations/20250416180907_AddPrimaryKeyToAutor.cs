using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRestFull.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryKeyToAutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "Livros",
                newName: "AutorIdAutor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Livros",
                newName: "IdLivro");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_AutorId",
                table: "Livros",
                newName: "IX_Livros_AutorIdAutor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Autores",
                newName: "IdAutor");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorIdAutor",
                table: "Livros",
                column: "AutorIdAutor",
                principalTable: "Autores",
                principalColumn: "IdAutor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorIdAutor",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "AutorIdAutor",
                table: "Livros",
                newName: "AutorId");

            migrationBuilder.RenameColumn(
                name: "IdLivro",
                table: "Livros",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_AutorIdAutor",
                table: "Livros",
                newName: "IX_Livros_AutorId");

            migrationBuilder.RenameColumn(
                name: "IdAutor",
                table: "Autores",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
