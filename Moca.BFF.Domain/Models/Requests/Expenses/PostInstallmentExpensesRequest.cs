namespace Moca.BFF.Domain.Models.Requests.Expenses
{
    public class PostInstallmentExpensesRequest
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoDespesa { get; set; }
        public int Parcelas { get; set; }
        public int IdCartao { get; set; }
    }
}
