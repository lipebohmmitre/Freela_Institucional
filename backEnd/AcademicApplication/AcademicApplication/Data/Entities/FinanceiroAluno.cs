namespace AcademicApplication.Data.Entities
{
    public class FinanceiroAluno
    {
        public int FinanceiroAlunoId { get; set; }

        public int MatriculaId { get; set; }
        public virtual Matricula Matricula { get; set; }

        public int FichaFinanceiraId { get; set; }
        public virtual FichaFinanceira FichaFinanceira { get; set; }
    }
}
