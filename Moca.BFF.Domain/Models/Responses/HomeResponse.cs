using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Models.Responses
{
    public class HomeResponse
    {

        public double saldo { get; set; }

        public double receita { get; set; }

        public double despesas { get; set; }

        public double despesaCartao { get; set; }

        public List<CartaoHome> cartoes { get; set; }

        public GraficoReceitas graficoReceitas { get; set; }

        public GraficoDespesas graficoDespesas { get; set; }

        public List<PorquinhoResponse> porquinhos { get; set; }

    }

    public record CartaoHome
    {
        public string bandeira { get; set; }
        public int idCor { get; set; }
        public string nome { get; set; }
    }

    public record GraficoReceitas
    {
        List<IndiceGrafico> indices = new List<IndiceGrafico>();
    }

    public record GraficoDespesas
    {
        List<IndiceGrafico> indices = new List<IndiceGrafico>();
    }

    public record IndiceGrafico
    {
        public string descricao { get; set; }
        public double porcentagem { get; set; }
    }

    public record PorquinhoResponseHome
    {
        public long id { get; set; }
        public string nome { get; set; }
        public double valorFinal { get; set; }
        public double valorAtual { get; set; }
        public bool isConcluido { get; set; }
        public long idCliente { get; set; }
    }
}
