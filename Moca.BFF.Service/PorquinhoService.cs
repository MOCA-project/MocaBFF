using Moca.BFF.Domain.Interfaces.Repositories;
using Moca.BFF.Domain.Interfaces.Services;
using Moca.BFF.Domain.Models.Requests.Porquinho;
using Moca.BFF.Domain.Models.Responses;

namespace Moca.BFF.Service
{
    public class PorquinhoService : IPorquinhoService
    {
        private readonly IPorquinhoRepository _porquinhoRepository;

        public PorquinhoService(IPorquinhoRepository porquinhoRepository)
        {
            _porquinhoRepository = porquinhoRepository;
        }

        public async Task DeletePorquinho(int idCliente, int idPorquinho)
        {
            await _porquinhoRepository.Delete(idCliente, idPorquinho);
        }

        public async Task Deposit(int clientId, int porquinhoId, decimal value)
        {
            await _porquinhoRepository.Deposit(clientId, porquinhoId, value);
        }

        public async Task FinalizePorquinho(int clientId, int porquinhoId)
        {
            await _porquinhoRepository.FinalizePorquinho(clientId, porquinhoId);

        }

        public async Task<List<PorquinhoResponse>> GetAllPorquinhosByClientId(int idCliente)
        {
            var result = await _porquinhoRepository.GetAllPorquinhosByClientId(idCliente);
            return result;    
        }

        public async Task<PostPorquinhoResponse> PostPorquinho(CreatePorquinhoRequest request)
        {
            var result = await _porquinhoRepository.PostPorquinho(request);
            return result;
        }

        public async Task Withdraw(int clientId, int porquinhoId, decimal withdrawValue)
        {
            await _porquinhoRepository.Withdraw(clientId, porquinhoId, withdrawValue);

        }
    }
}
