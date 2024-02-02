using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicApplication.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacoes_Tabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatusMatricula",
                table: "Matriculas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CodigoIESDE",
                table: "Disciplinas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusMatricula",
                table: "Matriculas");

            migrationBuilder.DropColumn(
                name: "CodigoIESDE",
                table: "Disciplinas");
        }
    }
}
