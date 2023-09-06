using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Models.Requests.Porquinho;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.External.Repositories
{
    public class PorquinhoRepository : BaseHttpClient, IPorquinhoRepository
    {
        protected override string ServiceName => "porquinhos";

        public async Task Deposit(int clientId, int porquinhoId, decimal value)
        {
            await ExecutePutAsync<dynamic>($"adicionarValor/{clientId}/{porquinhoId}/{value}", null);
        }

        public async Task FinalizePorquinho(int clientId, int porquinhoId)
        {
            await ExecutePutAsync<dynamic>($"finalizarPorquinho/{clientId}/{porquinhoId}", null);
        }

        public async Task<PostPorquinhoResponse> PostPorquinho(CreatePorquinhoRequest request)
        {
            var result = await ExecutePostAsync<PostPorquinhoResponse>(string.Empty, request);
            return result;
        }

        public async Task Withdraw(int clientId, int porquinhoId, decimal withdrawValue)
        {
            await ExecutePutAsync<dynamic>($"retirarValor/{clientId}/{porquinhoId}/{withdrawValue}", null);
        }
    }
}
