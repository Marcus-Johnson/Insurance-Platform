using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace NJInsurancePlatform.Controllers
{

    //[Authorize(Roles = "Customer")]
    [AllowAnnonymous] // WHILE DEVELOPING
	public class PolicyController : Controller
	{
		private readonly InsuranceCorpDbContext InsuranceCorpDbContext;

		public PolicyController(InsuranceCorpDbContext InsuranceCorpDbContext)
		{
			this.InsuranceCorpDbContext = InsuranceCorpDbContext;
		}
		
		//private readonly ILogger<PolicyController> _logger;

		//public PolicyController(ILogger<PolicyController> logger)
		//{
		//	_logger = logger;
		//}

		public IActionResult PolicyDetails()
		{
			return View();
		}

        public IActionResult PolicyRequest()
        {
            return View();
        }
    }
}
