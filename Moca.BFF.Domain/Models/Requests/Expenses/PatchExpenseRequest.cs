namespace Moca.BFF.Domain.Models.Requests.Expenses
{
    public class PatchExpenseRequest
    {
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}
