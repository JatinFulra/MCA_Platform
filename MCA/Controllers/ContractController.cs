using System.Diagnostics;
using MCA.Models;
using MCA.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MCA.Controllers
{
    public class ContractController : Controller
    {
        private readonly ILogger<ContractController> _logger;
        private readonly IContractService _contractService;


        public ContractController(ILogger<ContractController> logger, IContractService contractService)
        {
            _logger = logger;
            _contractService = contractService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetContracts()
        {
            var contracts = await _contractService.GetContractsAsync();
            return Json(contracts);  
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
