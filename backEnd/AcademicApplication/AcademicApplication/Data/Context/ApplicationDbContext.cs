using AcademicApplication.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcademicApplication.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Endereco> Enderecos { get; set;}
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Escolaridade> Escolaridades { get; set; }
        public DbSet<FichaFinanceira> FichasFinanceiras { get; set; }
        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<FinanceiroAluno> FinanceirosAlunos { get; set; }
        public DbSet<AreaAtuacao> AreasAtuacoes { get; set; }
    }
}
