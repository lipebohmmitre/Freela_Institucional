namespace AcademicApplication.Data.Entities
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }
        public string NomeDisciplina { get; set; } = string.Empty;
        public int CodigoIESDE { get; set; }
        public string AutorDisciplina { get; set; } = string.Empty;
        public string SupervisorDisciplina { get; set; } = string.Empty;
        public decimal CargaHorariaDisciplina { get; set; }


        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
