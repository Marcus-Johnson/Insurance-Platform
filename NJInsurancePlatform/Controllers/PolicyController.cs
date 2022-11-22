using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.Interfaces;
using NJInsurancePlatform.InterfaceImplementation;
using Microsoft.AspNetCore.Http.Features;

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
        [HttpGet]
        public async Task<IActionResult> PolicyRequest()
        {
            var pol = await PolicyRepository.GetPolicies();
            IEnumerable<Policy> pol2 = pol.ToList();
            //System.Diagnostics.Debug.WriteLine("HHEHEHEHEHEHEHEHEHEHEHEHHEHEHEHEHEHEHHEHEHEHEHEHEHEHHEHEHEHEHEHEHE" + pol);
            return View(pol2);
        }

        //public async RequestApprove()
        //{

        //}
        [HttpPost]
        public void PolicyRequest(Policy policy)
        {
            PolicyRepository.UpdatePolicy(policy);
            RedirectToAction("Index");
        }
    }
}