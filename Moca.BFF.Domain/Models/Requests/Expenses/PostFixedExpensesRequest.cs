namespace Moca.BFF.Domain.Models.Requests.Expenses
{
    public class PostFixedExpensesRequest
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoDespesa { get; set; }
        public bool Parcela { get; set; }
        public int IdCartao { get; set; }
        public bool IsCartao { get; set; }
        public bool Paid { get; set; }
    }
}
