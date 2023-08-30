using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Models.Responses
{
    public class PostInstallmentExpensesResponse
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
