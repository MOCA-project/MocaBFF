using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.External.Models
{
    public class ApiPostInstallmentExpenses
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
