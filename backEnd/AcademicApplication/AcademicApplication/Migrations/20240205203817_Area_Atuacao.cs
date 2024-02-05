using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicApplication.Migrations
{
    /// <inheritdoc />
    public partial class Area_Atuacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaCurso",
                table: "Cursos");

            migrationBuilder.AddColumn<int>(
                name: "AreaAtuacaoId",
                table: "Cursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AreasAtuacoes",
                columns: table => new
                {
                    AreaAtuacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaAtuacaoTitulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasAtuacoes", x => x.AreaAtuacaoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_AreaAtuacaoId",
                table: "Cursos",
                column: "AreaAtuacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_AreasAtuacoes_AreaAtuacaoId",
                table: "Cursos",
                column: "AreaAtuacaoId",
                principalTable: "AreasAtuacoes",
                principalColumn: "AreaAtuacaoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_AreasAtuacoes_AreaAtuacaoId",
                table: "Cursos");

            migrationBuilder.DropTable(
                name: "AreasAtuacoes");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_AreaAtuacaoId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "AreaAtuacaoId",
                table: "Cursos");

            migrationBuilder.AddColumn<string>(
                name: "AreaCurso",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
