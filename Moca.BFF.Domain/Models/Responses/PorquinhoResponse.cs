using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Models.Responses
{
    public class PorquinhoResponse
    {
        public string Nome { get; set; }
        public decimal ValorFinal { get; set; }
        public decimal ValorAtual { get; set; }
        public int IdCliente { get; set; }
        public int IdIcone { get; set; }
        public bool? Concluido { get; set; }
    }
}
