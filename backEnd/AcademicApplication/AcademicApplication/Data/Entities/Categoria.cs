namespace AcademicApplication.Data.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string NomeCategoria { get; set; } = string.Empty;


        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
