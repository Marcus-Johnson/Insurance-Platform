using Microsoft.AspNetCore.Mvc;

namespace NJInsurancePlatform.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }
    }
}