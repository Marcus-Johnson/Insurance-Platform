using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Controllers
{
    //[Authorize(Roles = "Customer")]
    [AllowAnonymous]
    public class PaymentController : Controller
    {

        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

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

        public IActionResult Details()
        {
            return View();
        }
    }
}
