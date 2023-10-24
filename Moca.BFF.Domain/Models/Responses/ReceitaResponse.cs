using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Models.Responses
{
    public class ReceitaResponse
    {
        public long IdReceita { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public long IdCliente { get; set; }
        public string IdTipoReceita { get; set; }
    }
}
