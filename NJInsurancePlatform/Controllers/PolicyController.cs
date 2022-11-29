using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.Interfaces;
using NJInsurancePlatform.InterfaceImplementation;
using Microsoft.AspNetCore.Http.Features;
using System.Diagnostics;

namespace NJInsurancePlatform.Controllers
{
    [AllowAnonymous]
    public class PolicyController : Controller
    {
        private readonly IPolicyRepository PolicyRepository;
        private readonly ITransactionRepository TransactionRepository;
        private readonly IProductRepository ProductRepository;
        private readonly ICustomerRepository customerRepository;

        public PolicyController(ITransactionRepository TransactionRepository, IPolicyRepository PolicyRepository, IProductRepository ProductRepository, ICustomerRepository customerRepository)
        {
            this.PolicyRepository = PolicyRepository;
            this.TransactionRepository = TransactionRepository;
            this.ProductRepository = ProductRepository;
            this.customerRepository = customerRepository;
        }


        public IActionResult PolicyDetails()
        {
            return View();
        }

        
        public async Task<IActionResult> PolicyRequest()
        {
            //var pol = await PolicyRepository.GetPolicies();
            //IEnumerable<Policy> pol2 = pol.ToList();
            //return View(pol2);

            var getPolicies = await PolicyRepository.GetPolicies();
            List<Policy> policies = new List<Policy>();
            foreach(var policy in getPolicies)
            {
                policies.Add(policy);
            }
            return View(policies);
        }


        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var getProducts = await ProductRepository.GetPolicies();

            List<Product> products = new List<Product>();

            foreach (var product in getProducts)
            {
                products.Add(product);
            };

            return View(products);
        }        
        
        
        [HttpPost]
        public async Task<IActionResult> PolicyRequest(Policy policy)
        {
            Policy updatedPolicy = new Policy()
            {
                PolicyMUID = policy.PolicyMUID,
                ProductMUID = policy.ProductMUID,
                CustomerMUID = policy.CustomerMUID,
                //PolicyNumber = policy.PolicyNumber,
                NameOfPolicy = policy.NameOfPolicy,
                PolicyOwner = policy.PolicyOwner,
                Deductible = policy.Deductible,
                OutOfPocketLimit = policy.OutOfPocketLimit,
                AnnualLimitOfCoverage = policy.AnnualLimitOfCoverage,
                PolicyPaymentisDue = policy.PolicyPaymentisDue,
                PolicyTotalAmount = policy.PolicyTotalAmount,
                PolicyPaidOffAmount = policy.PolicyPaidOffAmount,
                PolicyStart_Date = policy.PolicyStart_Date,
                PolicyEnd_Date = policy.PolicyEnd_Date,
                Pending = true,
            };
            PolicyRepository.UpdatePolicy(updatedPolicy);
            PolicyRepository.Save();
            return RedirectToAction("PolicyRequest");
        }
        protected override void Dispose(bool disposing)
        {
            PolicyRepository.Dispose();
            base.Dispose(disposing);
         }
        [HttpPost]
        public async Task<IActionResult> GetProducts(List<Product> model)
        {
            var getProducts = await ProductRepository.GetPolicies();

            List<Product> products = new List<Product>();

            foreach (var product in getProducts)
            {
                products.Add(product);
            };

            return View(products);


        }
    }
}