using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NJInsurancePlatform.Controllers
{
    [Authorize(Roles = "Admin, Customer")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        // JUST FOR THE PURPOSE OF TESTING ROLE MANAGEMENT
        public IActionResult MyPage()
        {
            return View();
        }
    }


}
