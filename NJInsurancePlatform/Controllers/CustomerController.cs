using Microsoft.AspNetCore.Mvc;

namespace NJInsurancePlatform.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
