using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicApplication.Migrations
{
    /// <inheritdoc />
    public partial class Financeiro_ALunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinanceirosAlunos",
                columns: table => new
                {
                    FinanceiroAlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatriculaId = table.Column<int>(type: "int", nullable: false),
                    FichaFinanceiraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceirosAlunos", x => x.FinanceiroAlunoId);
                    table.ForeignKey(
                        name: "FK_FinanceirosAlunos_FichasFinanceiras_FichaFinanceiraId",
                        column: x => x.FichaFinanceiraId,
                        principalTable: "FichasFinanceiras",
                        principalColumn: "FichaFinanceiraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinanceirosAlunos_Matriculas_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Matriculas",
                        principalColumn: "MatriculaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FinanceirosAlunos_FichaFinanceiraId",
                table: "FinanceirosAlunos",
                column: "FichaFinanceiraId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceirosAlunos_MatriculaId",
                table: "FinanceirosAlunos",
                column: "MatriculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinanceirosAlunos");
        }
    }
}
