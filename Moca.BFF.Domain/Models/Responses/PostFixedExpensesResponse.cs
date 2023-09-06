namespace Moca.BFF.Domain.Models.Responses
{
    public class PostFixedExpensesResponse
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public string IdTipoDespesa { get; set; }
        public bool Parcela { get; set; }
        public bool IsCartao { get; set; }
        public bool Paid { get; set; }


    }
}
