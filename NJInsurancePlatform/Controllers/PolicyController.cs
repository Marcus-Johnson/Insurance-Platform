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

        [Authorize(Roles = "Customer, Beneficiary, Pending")]
        [HttpGet]
        public IActionResult PolicyDetails()
        {
            if (User.Identity.Name == null) return RedirectToAction("AccessDenied", "Administration");
            return View();
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> PolicyRequest()
        {
            if (User.Identity.Name == null) return RedirectToAction("AccessDenied", "Administration");
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


        [Authorize(Roles = "Customer, Pending, Beneficiary")]
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            if (User.Identity.Name == null) return RedirectToAction("AccessDenied", "Administration");

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
                PolicyPaymentisDue = true,
                PolicyTotalAmount = policy.PolicyTotalAmount,
                PolicyPaidOffAmount = policy.PolicyPaidOffAmount,
                PolicyStart_Date = policy.PolicyStart_Date,
                PolicyEnd_Date = policy.PolicyEnd_Date,
                Pending = false,
            };
            PolicyRepository.UpdatePolicy(updatedPolicy);
            PolicyRepository.Save();

            return RedirectToAction("PolicyRequest");
        }


        // If No Bill Exists, create a new bill
        //if(model.Bill == null)
        //{
        //    Bill newBill = new Bill()
        //    {
        //        BillMUID = Guid.NewGuid(),
        //        PolicyMUID = policyMUID,
        //        PolicyDueDate = DateTime.Now,
        //        MinimumPayment = (double)roundedPayment,
        //        CreatedDate = DateTime.Now,
        //        Balance = (double)model.Product.Price,
        //        Status = "Due",
        //    };

        //    BillRepository.InsertBill(newBill);
        //    BillRepository.Save();

        protected override void Dispose(bool disposing)
        {
            PolicyRepository.Dispose();
            base.Dispose(disposing);
         }


        [Authorize(Roles = "Customer, Pending, Beneficiary")]
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