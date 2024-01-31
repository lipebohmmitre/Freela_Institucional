namespace AcademicApplication.Data.Entities
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string NomeFuncionario { get; set; }
        public string CpfFuncionario { get; set; }
        public string RgFuncionario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }
        public bool Status { get; set; }
        public string Funcao { get; set; }
    }
}
