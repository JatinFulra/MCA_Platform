using MCA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA.Repository.Interfaces
{
    public interface IContractRepository
    {
        Task<List<ContractModel>> GetContractsAsync();
    }
}
