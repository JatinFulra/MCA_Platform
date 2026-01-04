using Microsoft.AspNetCore.Mvc;

namespace MCA.Controllers
{
    public class MerchantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
