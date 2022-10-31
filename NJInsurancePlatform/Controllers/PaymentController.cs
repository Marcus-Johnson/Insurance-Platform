using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Payment(PaymentModel model)
        {
            return View();
        }
    }
}