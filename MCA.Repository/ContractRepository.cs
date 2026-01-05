using MCA.Data;
using MCA.Domain.Models;
using MCA.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MCA.Repository
{
    public class ContractRepository: IContractRepository
    {
        private readonly AppDbContext _context;

        public ContractRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ContractModel>> GetContractsAsync()
        {
            return await _context.MasterContracts
                .FromSqlRaw("EXEC dbo.sp_GetContracts")
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
