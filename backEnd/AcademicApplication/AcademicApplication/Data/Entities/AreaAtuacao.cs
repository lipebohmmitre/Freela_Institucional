namespace AcademicApplication.Data.Entities
{
    public class AreaAtuacao
    {
        public int AreaAtuacaoId { get; set; }
        public string AreaAtuacaoTitulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;


        public virtual ICollection<Curso>? Cursos { get; set; }
    }
}
