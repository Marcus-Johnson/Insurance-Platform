﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly IProductRepository ProductRepository;

        public PolicyController(ITransactionRepository TransactionRepository, IPolicyRepository PolicyRepository, IProductRepository ProductRepository)
        {
            this.PolicyRepository = PolicyRepository;
            this.TransactionRepository = TransactionRepository;
            this.ProductRepository = ProductRepository;
        }


        public IActionResult PolicyDetails()
        {
            return View();
        }

        public async Task<IActionResult> PolicyRequest()
        {
            var pol = await PolicyRepository.GetPolicies();
            var pol2 = pol.ToList();

            return View(pol2);
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
    }
}