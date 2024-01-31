namespace AcademicApplication.Data.Entities
{
    public class Escolaridade
    {
        public int EscolaridadeId { get; set; }
        public string EscolaridadeAluno { get; set; } = string.Empty;
        public string CursoSuperior { get; set; } = string.Empty;
        public string InstituicaoCursoSuperior { get; set; } = string.Empty;
        public string EscolaEnsinoMédio { get; set; } = string.Empty;
        public DateTime DataConclusaoEnsinoMedio { get; set; }
        public string EstadoEnsinoMedio { get; set; } = string.Empty;
        public string CidadeEnsinoMedio { get; set; } = string.Empty;
        public string EscolaEnsinoFundamental { get; set; } = string.Empty;
        public DateTime DataConclusaoEnsinoFundamental { get; set; }
        public string EstadoEnsinoFundamental { get; set; } = string.Empty;
        public string CidadeEnsinoFundamental { get; set; } = string.Empty;
    }
}
