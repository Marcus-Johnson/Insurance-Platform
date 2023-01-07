using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Interfaces;

namespace NJInsurancePlatform.Controllers
{
    //[AllowAnonymous]
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
            if (User.IsInRole("Admin")) return RedirectToAction("GetRoles", "Administration");

            var allBills = await BillRepository.GetBills();                                         // Get Policies
            var allPolicies = await policyRepository.GetPolicies();                                         // Get Policies
            var identityUserName = User.Identity?.Name;                                                     // Get Identity of User Signed Ub
            var user = await userManager.FindByNameAsync(identityUserName);                                 //Find User By Identity
            var findPolicyByCustomerMUID = allPolicies.FindAll(p => p.CustomerMUID == user.CustomerMUID);   //Find All policies With That CustomerMUID
            var allTransactions = await transactionRepository.GetTransactions();
            var findTransactionByCustomerMUID = allTransactions.FindAll(t => t.CustomerMUID == user.CustomerMUID);



            CustomerHomePageVieModel customerHomePageVieModel = new CustomerHomePageVieModel();

            // Add Policies To Customer List Items
            foreach (var bill in allBills)
            {
                foreach (var policy in findPolicyByCustomerMUID)
                {
                    var billAllReadyThere = customerHomePageVieModel.Bills.Exists(b => b.BillMUID == bill.BillMUID);
                    var policyAllReadyThere = customerHomePageVieModel.Policies.Exists(p => p.PolicyMUID == policy.PolicyMUID);

                    if (bill.PolicyMUID == policy.PolicyMUID && !billAllReadyThere)
                    {
                        customerHomePageVieModel.Bills.Add(bill);

                    }
                    if (!policyAllReadyThere)
                    {
                        customerHomePageVieModel.Policies?.Add(policy);

                    }
                }
                //customerHomePageVieModel.PolicyNames?.Add(policy?.NameOfPolicy);

            }

            customerHomePageVieModel.ApplicationUser = user;

            // Add Transactions To customer List Items
            foreach (var transaction in findTransactionByCustomerMUID)
            {
                var transactionAllreadyThere = customerHomePageVieModel.Transactions.Exists(t => t.TransactionMUID == transaction.TransactionMUID);

                if (!transactionAllreadyThere)
                {
                    customerHomePageVieModel.Transactions?.Add(transaction);

                    customerHomePageVieModel.Transactions?.Sort((x, y) => DateTime.Compare(x.PaymentDate, y.PaymentDate));

                }
            }

            return View(customerHomePageVieModel);
        }

        [Authorize(Roles = "Customer, Pending, Beneficiary")]
        [HttpGet]
        public async Task<ActionResult> CustomerPolicyRequest(string Id)
        {
            var allProducts = await productRepository.GetPolicies();                                        // Get Products
            var allBills = await BillRepository.GetBills();
            var identityUserName = User.Identity?.Name;                                                     // Get Identity of User Signed Ub
            var user = await userManager.FindByNameAsync(identityUserName);                                 //Find User By Identity
            var product = allProducts.FirstOrDefault(p => p.ProductMUID.ToString() == Id);                  //Find Product Clicked On
            var customerMUID = new Guid(user.CustomerMUID.ToString());

            CustomerPolicyRequestViewModel customerRequestView = new CustomerPolicyRequestViewModel()
            {
                Product = product,
                Customer = user,
            };

            // Get Bill that matches Customer
            foreach (var bill in allBills)
            {
                var billExists = customerRequestView.Bills.Exists(b => b.BillMUID == bill.BillMUID);

                if (bill.CustomerMUID == user.CustomerMUID && !billExists)
                {
                    customerRequestView.Bills.Add(bill);
                }
            }

            return View(customerRequestView);
        }


        [HttpPost]
        public async Task<ActionResult> CustomerPolicyRequest(CustomerPolicyRequestViewModel model)
        {
            var customerMUID = new Guid(model.Customer.CustomerMUID.ToString());
            var policyMUID = Guid.NewGuid();
            var minimumPayment = (decimal)model.Product.Price / 12;   // price of product divided by 12 installments
            var roundedPayment = Decimal.Round(minimumPayment, 2);    // rounded 
            //Decimal existingMinimumPayment = (decimal)model.Bill.MinimumPayment;


            // Reuse Entity Already Being Tracked By The DbContext
            var user = await userManager.FindByIdAsync(model.Customer.Id);
            var allBills = await BillRepository.GetBills();
            var userBills = allBills.FindAll(b => b.CustomerMUID == user.CustomerMUID);
            var userBillsCount = userBills.Count();


            Policy newPolicy = new Policy()
            {
                //PolicyMUID = Guid.NewGuid(),
                PolicyMUID = policyMUID,
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
                PolicyStart_Date = DateTime.Now,
                PolicyEnd_Date = DateTime.Now.AddDays(365),
                Pending = true,
            };

            // Insert and Save
            policyRepository.InsertPolicy(newPolicy);
            policyRepository.Save();


            // BELOW SHOULD BE ADDED TO POLICY REQUEST CONTROLLER /////////////////////////////
            // Create a new bill on policy request with a status of DUE
            Bill newBill = new Bill()
            {
                BillMUID = Guid.NewGuid(),
                PolicyMUID = policyMUID,
                CustomerMUID = customerMUID,
                PolicyDueDate = DateTime.Now,
                MinimumPayment = (double)roundedPayment,
                CreatedDate = DateTime.Now,
                Balance = (double)model.Product.Price,
                Status = "Due",
            };

            BillRepository.InsertBill(newBill);
            BillRepository.Save();

            return RedirectToAction("Index", "Customer");
        }


        [Authorize(Roles = "Customer, Beneficiary")]
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }


        [Authorize(Roles = "Customer, Beneficiary")]
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
        [Authorize(Roles = "Customer, Beneficiary")]
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