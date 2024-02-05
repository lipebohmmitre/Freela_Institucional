namespace AcademicApplication.Data.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string NomeCurso { get; set; } = string.Empty;
        public string TipoCurso { get; set; } = string.Empty;
        public bool StatusCurso { get; set; } = true;


        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


        public int AreaAtuacaoId { get; set; }
        public virtual AreaAtuacao AreaAtuacao { get; set; }


        public virtual ICollection<Disciplina> Disciplinas { get; set; }

        
    }
}
