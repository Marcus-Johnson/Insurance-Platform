using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace NJInsurancePlatform.Controllers
{
	public class PolicyController : Controller
	{
		private readonly InsuranceCorpDbContext InsuranceCorpDbContext;

		public PolicyController(InsuranceCorpDbContext InsuranceCorpDbContext)
		{
			this.InsuranceCorpDbContext = InsuranceCorpDbContext;
		}
	}
}
