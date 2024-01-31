namespace AcademicApplication.Data.Entities
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public DateTime DataMatricula { get; set; }
        public string ObservacaoMatricula { get; set; }

   
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }


        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }

        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }

    }
}
