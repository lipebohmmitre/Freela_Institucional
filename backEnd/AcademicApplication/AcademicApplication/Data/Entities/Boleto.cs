namespace AcademicApplication.Data.Entities
{
    public class Boleto
    {
        public int BoletoId { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorFinal { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataGeracao { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Banco { get; set; } = string.Empty;
        public int Parcela { get; set; }


        public int FichaFinanceiraId { get; set; }
        public virtual FichaFinanceira FichaFinanceira { get; set; }
    }
}
