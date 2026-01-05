using MCA.Services.Interfaces;
using MCA.Repository.Interfaces;
using MCA.Domain.Models;
namespace MCA.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _repository;

        public ContractService(IContractRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<ContractModel>> GetContractsAsync()
        {
            return await _repository.GetContractsAsync();
        }

    }
}
