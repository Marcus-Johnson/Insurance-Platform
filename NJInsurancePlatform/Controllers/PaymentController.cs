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
        public IActionResult MakePayment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakePayment(Payment model)
        {
            return View();
        }
    }
}