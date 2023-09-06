using Moca.BFF.Domain.Models.Requests.Porquinho;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Domain.Interfaces.Repositories
{
    public interface IPorquinhoRepository
    {
        Task Deposit(int clientId, int porquinhoId, decimal value);
        Task FinalizePorquinho(int clientId, int porquinhoId);
        Task<PostPorquinhoResponse> PostPorquinho(CreatePorquinhoRequest request);
        Task Withdraw(int clientId, int porquinhoId, decimal withdrawValue);
    }
}
