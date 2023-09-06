namespace Moca.BFF.Domain.Models.Responses
{
    public class PostInstallmentExpensesResponse
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public string IdTipoDespesa { get; set; }
        public int Parcelas { get; set; }
        public int IdCartao { get; set; }
    }
}
