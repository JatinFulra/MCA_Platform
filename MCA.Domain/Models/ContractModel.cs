using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCA.Domain.Models
{
    public class ContractModel
    {
        [Key]
        public int ContractID { get; set; }
        public string? MerchantName { get; set; }
        public string? MerchantBusinessName { get; set; }
        public string? Syndicate { get; set; }
        public string? ISO { get; set; }
        public int FundsAdvance { get; set; }
    }
}
