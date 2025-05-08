using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaboratorioDeTestesAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjustesModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_IdAutor",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_IdAutor",
                table: "Livros");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<Guid>(
                name: "AutorIdAutor",
                table: "Livros",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_AutorIdAutor",
                table: "Livros",
                column: "AutorIdAutor");

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

            migrationBuilder.DropIndex(
                name: "IX_Livros_AutorIdAutor",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "AutorIdAutor",
                table: "Livros");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Livros",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "Autores",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Autores",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_IdAutor",
                table: "Livros",
                column: "IdAutor");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_IdAutor",
                table: "Livros",
                column: "IdAutor",
                principalTable: "Autores",
                principalColumn: "IdAutor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
