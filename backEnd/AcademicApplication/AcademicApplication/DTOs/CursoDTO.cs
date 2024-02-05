namespace AcademicApplication.DTOs
{
    public class CursoDTO
    {
        public int CursoId { get; set; }
        public string NomeCurso { get; set; } = string.Empty;
        public string TipoCurso { get; set; } = string.Empty;
        public string AreaCurso { get; set; } = string.Empty;
        public bool StatusCurso { get; set; } = true;
        public int CategoriaId { get; set; }
    }
}
