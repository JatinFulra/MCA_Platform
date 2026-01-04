using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Principal;
using MCA.Domain.Models;


namespace MCA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContractModel> MasterContracts { get; set; }
    }
}
