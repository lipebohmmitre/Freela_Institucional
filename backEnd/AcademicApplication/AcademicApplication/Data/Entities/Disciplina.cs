namespace AcademicApplication.Data.Entities
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }
        public string NomeDisciplina { get; set; }
        public string AutorDisciplina { get; set; }
        public string SupervisorDisciplina { get; set; }
        public decimal CargaHorariaDisciplina { get; set; }


        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
