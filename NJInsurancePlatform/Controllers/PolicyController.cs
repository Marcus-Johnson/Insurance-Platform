using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.Interfaces;
using NJInsurancePlatform.InterfaceImplementation;

namespace NJInsurancePlatform.Controllers
{
    [AllowAnonymous]
    public class PolicyController : Controller
    {
        private readonly IPolicyRepository PolicyRepository;
        private readonly ITransactionRepository TransactionRepository;

        public PolicyController(ITransactionRepository TransactionRepository, IPolicyRepository PolicyRepository)
        {
            this.PolicyRepository = PolicyRepository;
            this.TransactionRepository = TransactionRepository;
        }


        public IActionResult PolicyDetails()
        {
            return View();
        }

        public async Task<IActionResult> PolicyRequest()
        {
            var pol = await PolicyRepository.GetPolicies();
            var pol2 = pol.ToList();
            //System.Diagnostics.Debug.WriteLine("HHEHEHEHEHEHEHEHEHEHEHEHHEHEHEHEHEHEHHEHEHEHEHEHEHEHHEHEHEHEHEHEHE" + pol);
            return View(pol2);
        }
    }
}