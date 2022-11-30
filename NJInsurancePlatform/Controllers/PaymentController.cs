using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Interfaces;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Controllers
{

    //[Authorize(Roles = "Customer")]
    [AllowAnonymous] // WHILE DEVELOPING

    public class PaymentController : Controller
    {

        private readonly ILogger<PaymentController> _logger;
        private readonly IPolicyRepository PolicyRepository;
        private readonly ITransactionRepository TransactionRepository;
        private readonly iBillRepository BillRepository;
        private readonly IPaymentRepository PaymentRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public PaymentController(ILogger<PaymentController> logger, IPolicyRepository PolicyRepository, ITransactionRepository TransactionRepository, iBillRepository BillRepository, IPaymentRepository PaymentRepository, UserManager<ApplicationUser> userManager)
        {
            this.PolicyRepository = PolicyRepository;
            this.TransactionRepository = TransactionRepository;
            this.BillRepository = BillRepository;
            this.PaymentRepository = PaymentRepository;
            this.userManager = userManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MakePayment()
        {
            var policy = await PolicyRepository.GetPolicies();
            var identityUser = User.Identity.Name;
            var user = await userManager.FindByNameAsync(identityUser);
            Policy getPolicy = policy.FirstOrDefault(p => p.CustomerMUID == user.CustomerMUID);
            var Bills = await BillRepository.GetBills();
            Bill getBillbyID = Bills.FirstOrDefault(b => b.PolicyMUID == user.PolicyMUID);
            
            PaymentViewModel paymentViewModel = new PaymentViewModel() 
            { 
                Policy = getPolicy,
                ApplicationUser = user,
                Bill = getBillbyID,
            };

            return View(paymentViewModel);
        }


        [HttpPost]
        public IActionResult MakePayment(Payment model)
        {
            return View("Index");
        }

        public IActionResult Details()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UpdateBill(Bill bill)
        {

            Bill updatedBill = new Bill()
            {
                BillMUID = bill.BillMUID,
                PolicyMUID = bill.PolicyMUID,
                PolicyDueDate = bill.PolicyDueDate,
                MinimumPayment = bill.MinimumPayment,
                CreatedDate = bill.CreatedDate,
                Balance = bill.Balance,
                Status = bill.Status,
            };

            BillRepository.UpdateBill(updatedBill);
            BillRepository.Save();
            return RedirectToAction("Index");
        }
    }
}
