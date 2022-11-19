using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using NJInsurancePlatform.Models;

using Microsoft.AspNetCore.Authorization;

namespace NJInsurancePlatform.Controllers
{
    [AllowAnonymous]
    public class ClaimController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
 
        public ClaimController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}