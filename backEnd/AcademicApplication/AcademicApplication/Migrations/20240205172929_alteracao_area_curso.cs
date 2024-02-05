using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicApplication.Migrations
{
    /// <inheritdoc />
    public partial class alteracao_area_curso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaCurso",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaCurso",
                table: "Cursos");
        }
    }
}
