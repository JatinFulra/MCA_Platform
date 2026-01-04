using System.Diagnostics;
using MCA.Models;
using Microsoft.AspNetCore.Mvc;

namespace MCA.Controllers
{
    public class ContractController : Controller
    {
        private readonly ILogger<ContractController> _logger;

        public ContractController(ILogger<ContractController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
