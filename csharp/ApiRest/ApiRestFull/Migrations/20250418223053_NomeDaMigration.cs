using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRestFull.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorIdAutor",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "AutorIdAutor",
                table: "Livros",
                newName: "AutorModelIdAutor");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_AutorIdAutor",
                table: "Livros",
                newName: "IX_Livros_AutorModelIdAutor");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorModelIdAutor",
                table: "Livros",
                column: "AutorModelIdAutor",
                principalTable: "Autores",
                principalColumn: "IdAutor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorModelIdAutor",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "AutorModelIdAutor",
                table: "Livros",
                newName: "AutorIdAutor");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_AutorModelIdAutor",
                table: "Livros",
                newName: "IX_Livros_AutorIdAutor");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorIdAutor",
                table: "Livros",
                column: "AutorIdAutor",
                principalTable: "Autores",
                principalColumn: "IdAutor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
