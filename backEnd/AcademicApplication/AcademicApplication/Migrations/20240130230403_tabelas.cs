using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicApplication.Migrations
{
    /// <inheritdoc />
    public partial class tabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    DisciplinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDisciplina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutorDisciplina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupervisorDisciplina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargaHorariaDisciplina = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.DisciplinaId);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Escolaridades",
                columns: table => new
                {
                    EscolaridadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscolaridadeAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CursoSuperior = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstituicaoCursoSuperior = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscolaEnsinoMédio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataConclusaoEnsinoMedio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoEnsinoMedio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeEnsinoMedio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscolaEnsinoFundamental = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataConclusaoEnsinoFundamental = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoEnsinoFundamental = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeEnsinoFundamental = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolaridades", x => x.EscolaridadeId);
                });

            migrationBuilder.CreateTable(
                name: "FichasFinanceiras",
                columns: table => new
                {
                    FichaFinanceiraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeParcelas = table.Column<int>(type: "int", nullable: false),
                    ValorParcelas = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichasFinanceiras", x => x.FichaFinanceiraId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RgFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDesligamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioId);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCurso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCurso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusCurso = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                    table.ForeignKey(
                        name: "FK_Cursos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeSocialAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UfRG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgaoExpedidorRg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataExpedicaoRg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TituloEleitor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessaoTituloEleitor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZonaTituloEleitor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefoneAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefoneSecundarioAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoNascimentoAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeNascimentoAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailSecundarioAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SexoAluno = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ProfissaoAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePaiAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeMaeAluno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false),
                    EscolaridadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoId);
                    table.ForeignKey(
                        name: "FK_Alunos_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alunos_Escolaridades_EscolaridadeId",
                        column: x => x.EscolaridadeId,
                        principalTable: "Escolaridades",
                        principalColumn: "EscolaridadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boletos",
                columns: table => new
                {
                    BoletoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorBruto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataGeracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Banco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parcela = table.Column<int>(type: "int", nullable: false),
                    FichaFinanceiraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletos", x => x.BoletoId);
                    table.ForeignKey(
                        name: "FK_Boletos_FichasFinanceiras_FichaFinanceiraId",
                        column: x => x.FichaFinanceiraId,
                        principalTable: "FichasFinanceiras",
                        principalColumn: "FichaFinanceiraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursoDisciplina",
                columns: table => new
                {
                    CursosCursoId = table.Column<int>(type: "int", nullable: false),
                    DisciplinasDisciplinaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoDisciplina", x => new { x.CursosCursoId, x.DisciplinasDisciplinaId });
                    table.ForeignKey(
                        name: "FK_CursoDisciplina_Cursos_CursosCursoId",
                        column: x => x.CursosCursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoDisciplina_Disciplinas_DisciplinasDisciplinaId",
                        column: x => x.DisciplinasDisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "DisciplinaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    MatriculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataMatricula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObservacaoMatricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlunoId = table.Column<int>(type: "int", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.MatriculaId);
                    table.ForeignKey(
                        name: "FK_Matriculas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "AlunoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EnderecoId",
                table: "Alunos",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EscolaridadeId",
                table: "Alunos",
                column: "EscolaridadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Boletos_FichaFinanceiraId",
                table: "Boletos",
                column: "FichaFinanceiraId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoDisciplina_DisciplinasDisciplinaId",
                table: "CursoDisciplina",
                column: "DisciplinasDisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_CategoriaId",
                table: "Cursos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_AlunoId",
                table: "Matriculas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_CursoId",
                table: "Matriculas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_FuncionarioId",
                table: "Matriculas",
                column: "FuncionarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boletos");

            migrationBuilder.DropTable(
                name: "CursoDisciplina");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "FichasFinanceiras");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Escolaridades");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
