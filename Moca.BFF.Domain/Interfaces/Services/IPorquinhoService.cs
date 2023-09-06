using Moca.BFF.Domain.Models.Requests.Porquinho;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Domain.Interfaces.Services
{
    public interface IPorquinhoService
    {
        Task DeletePorquinho(int idCliente, int idPorquinho);
        Task Deposit(int clientId, int porquinhoId, decimal value);
        Task FinalizePorquinho(int clientId, int porquinhoId);
        Task<List<PorquinhoResponse>> GetAllPorquinhosByClientId(int idCliente);
        Task<PostPorquinhoResponse> PostPorquinho(CreatePorquinhoRequest request);
        Task Withdraw(int clientId, int porquinhoId, decimal withdrawValue);
    }
}
