using Microsoft.AspNetCore.Mvc;

namespace NJInsurancePlatform.Controllers
{
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

        public IActionResult Details()
        {
            return View();
        }
    }
}
