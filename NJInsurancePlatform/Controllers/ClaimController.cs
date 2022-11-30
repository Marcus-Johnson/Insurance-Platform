using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using NJInsurancePlatform.Models;

using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.Interfaces;
using NJInsurancePlatform.InterfaceImplementation;

namespace NJInsurancePlatform.Controllers
{

    [AllowAnonymous]
    public class ClaimController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly iClaimRepository ClaimRepository;
 
        public ClaimController(UserManager<ApplicationUser> userManager, iClaimRepository ClaimRepository)
        {
            this.userManager = userManager;
            this.ClaimRepository = ClaimRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateClaim()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateClaim(Claim model)
        {
            var claim = new Claim
            {
                ClaimMUID = model.ClaimMUID,
                PolicyMUID = model.PolicyMUID,
                CustomerMUID = model.CustomerMUID,
                ClaimUserDescription = model.ClaimUserDescription,
                DateOfClaim = DateTime.Now
            };

            ClaimRepository.InsertClaim(claim);
            ClaimRepository.Save();
            return RedirectToAction("Index", "Home");

        }

    }
}