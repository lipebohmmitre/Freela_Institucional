namespace AcademicApplication.Data.Entities
{
    public class FichaFinanceira
    {
        public int FichaFinanceiraId { get; set; }
        public int QuantidadeParcelas { get; set; }
        public int ValorParcelas { get; set; }
        public DateTime DataCriacao { get; set; }


        public ICollection<Boleto> Boletos { get; set; }

    }
}
