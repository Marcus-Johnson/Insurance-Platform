using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using NJInsurancePlatform.Models;

using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.InterfaceImplementation;

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

        public CustomerController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, 
            IPolicyRepository policyRepository, ITransactionRepository transactionRepository, IProductRepository productRepository, 
            ICustomerRepository customerRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.policyRepository = policyRepository;
            this.transactionRepository = transactionRepository;
            this.productRepository = productRepository;
            this.customerRepository = customerRepository;
        }
        public async Task<IActionResult> Index()
        {

            var allPolicies = await policyRepository.GetPolicies();                                         // Get Policies
            var identityUserName = User.Identity?.Name;                                                     // Get Identity of User Signed Ub
            var user = await userManager.FindByNameAsync(identityUserName);                                 //Find User By Identity
            var findPolicyByCustomerMUID = allPolicies.FindAll(p => p.CustomerMUID == user.CustomerMUID);   //Find All policies With That CustomerMUID
            var allTransactions = await transactionRepository.GetTransactions();
            var findTransactionByCustomerMUID = allTransactions.FindAll(t => t.CustomerMUID == user.CustomerMUID);
            
            CustomerHomePageVieModel customerHomePageVieModel = new CustomerHomePageVieModel();

            // Add Policies To Customer List Items
            foreach(var policy in findPolicyByCustomerMUID)
            {
                customerHomePageVieModel.Policies?.Add(policy);
                customerHomePageVieModel.PolicyNames?.Add(policy?.NameOfPolicy);
            }

            // Add Transactions To customer List Items
            foreach(var transaction in findTransactionByCustomerMUID)
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
            var product = allProducts.FirstOrDefault(p => p.ProductMUID.ToString() == Id);            //Find Product Clicked On
            var customerMUID = new Guid(user.CustomerMUID.ToString());
            var policyMUID = new Guid(user.PolicyMUID.ToString());

            CustomerPolicyRequestViewModel customerRequestView = new CustomerPolicyRequestViewModel()
            {
                CustomerMUID = customerMUID,
                PolicyMUID = policyMUID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.EmailAddress,
                PhoneNumber = user.PhoneNumber,
                CurrentAddress = user.CurrentAddress,
                CurrentCity = user.CurrentCity,
                CurrentZipcode = user.CurrentZipcode,
                CurrentState = user.CurrentState,
                CurrentEmployer = user.CurrentEmployer,
                LicenseNumber = user.LicenseNumber,
                IsPrimaryPolicyHolder = user.IsPrimaryPolicyHolder,
                CreatedDate = user.CreatedDate.ToString(),
                Active = user.Active

                
            };

            return View(customerRequestView);
        }        
        
        
        [HttpPost]
        public async Task<ActionResult> CustomerPolicyRequest(CustomerPolicyRequestViewModel model)                                     
        {

            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>>>>>>>>> " + model.Product.ProductMUID);


            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>>>>> " + model.PolicyRequest.RequestMUID);
            return View();
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
    }
}