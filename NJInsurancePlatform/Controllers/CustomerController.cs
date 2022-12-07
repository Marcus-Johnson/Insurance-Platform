using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using NJInsurancePlatform.Models;

using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Interfaces;

namespace NJInsurancePlatform.Controllers
{
    [AllowAnonymous]
    public class CustomerController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IPolicyRepository policyRepository;
        private readonly ITransactionRepository transactionRepository;
        private readonly IProductRepository productRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly iClaimRepository ClaimRepository;
        private readonly iBillRepository BillRepository;

        public CustomerController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, 
            IPolicyRepository policyRepository, ITransactionRepository transactionRepository, IProductRepository productRepository, 
            ICustomerRepository customerRepository, iClaimRepository ClaimRepository, iBillRepository billRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.policyRepository = policyRepository;
            this.transactionRepository = transactionRepository;
            this.productRepository = productRepository;
            this.customerRepository = customerRepository;
            this.ClaimRepository = ClaimRepository;
            this.BillRepository = billRepository;
        }


        public async Task<IActionResult> Index()
        {

            var allBills = await BillRepository.GetBills();                                         // Get Policies
            var allPolicies = await policyRepository.GetPolicies();                                         // Get Policies
            var identityUserName = User.Identity?.Name;                                                     // Get Identity of User Signed Ub
            var user = await userManager.FindByNameAsync(identityUserName);                                 //Find User By Identity
            var findPolicyByCustomerMUID = allPolicies.FindAll(p => p.CustomerMUID == user.CustomerMUID);   //Find All policies With That CustomerMUID
            var allTransactions = await transactionRepository.GetTransactions();
            var findTransactionByCustomerMUID = allTransactions.FindAll(t => t.CustomerMUID == user.CustomerMUID);

            CustomerHomePageVieModel customerHomePageVieModel = new CustomerHomePageVieModel();

            // Add Policies To Customer List Items
            foreach (var policy in findPolicyByCustomerMUID)
            {
                foreach (var bill in allBills)
                {

                    if (bill.PolicyMUID == policy.PolicyMUID)
                    {
                        customerHomePageVieModel.Bills.Add(bill);
                    }
                }
                customerHomePageVieModel.Policies?.Add(policy);
                customerHomePageVieModel.PolicyNames?.Add(policy?.NameOfPolicy);

            }

            customerHomePageVieModel.ApplicationUser = user;

            // Add Transactions To customer List Items
            foreach (var transaction in findTransactionByCustomerMUID)
            {
                customerHomePageVieModel.Transactions?.Add(transaction);
            }

            return View(customerHomePageVieModel);
        }


        [HttpGet]
        public async Task<ActionResult> CustomerPolicyRequest(string Id)                                     
        {            
            var allProducts = await productRepository.GetPolicies();                                        // Get Products
            var identityUserName = User.Identity?.Name;                                                     // Get Identity of User Signed Ub
            var user = await userManager.FindByNameAsync(identityUserName);                                 //Find User By Identity
            var product = allProducts.FirstOrDefault(p => p.ProductMUID.ToString() == Id);                  //Find Product Clicked On
            var customerMUID = new Guid(user.CustomerMUID.ToString());

            CustomerPolicyRequestViewModel customerRequestView = new CustomerPolicyRequestViewModel()
            {
                Product = product,
                Customer = user,
            };

            return View(customerRequestView);
        }        
        
        
        [HttpPost]
        public async Task<ActionResult> CustomerPolicyRequest(CustomerPolicyRequestViewModel model)                                     
        {
            var customerMUID = new Guid(model.Customer.CustomerMUID.ToString());

            Policy policy = new Policy()
            {
                PolicyMUID = Guid.NewGuid(),
                ProductMUID = model.Product.ProductMUID,
                CustomerMUID = customerMUID,
                NameOfPolicy = model.Product.ProductName,
                PolicyOwner = model.Customer.FirstName + model.Customer.LastName,
                Deductible = model.Product.Deductible,
                OutOfPocketLimit = model.Product.OutOfPocketLimit,
                AnnualLimitOfCoverage = model.Product.AnnualLimitOfCoverage,
                PolicyPaymentisDue = true,
                PolicyTotalAmount = model.Product.PolicyTotalAmount,
                PolicyPaidOffAmount = 0,
                Pending = true,
            };

            policyRepository.InsertPolicy(policy);
            policyRepository.Save();

            return RedirectToAction("Index", "Customer");
        }


        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Claim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Claim(Claim model)
        {
            return View();
        }

        // JUST FOR THE PURPOSE OF TESTING ROLE MANAGEMENT
        public IActionResult MyPage()
        {
            return View();
        }    
        

        // NEW CODE
        [HttpPost]
        public IActionResult CreateClaim(CustomerHomePageVieModel model)
        {

            var claim = new Claim
            {
                ClaimMUID = Guid.NewGuid(),
                PolicyMUID = model.Claim.PolicyMUID.ToString(),
                CustomerMUID = model.Claim.CustomerMUID.ToString(),
                ClaimUserDescription = model.Claim.ClaimUserDescription,
                DateOfClaim = DateTime.Now
            };

            ClaimRepository.InsertClaim(claim);
            ClaimRepository.Save();
            return RedirectToAction("Index", "Home");

        }
    }
}