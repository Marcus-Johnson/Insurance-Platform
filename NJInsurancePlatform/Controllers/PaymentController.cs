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
    //[AllowAnonymous] // WHILE DEVELOPING
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

        [Authorize(Roles = "Customer, Pending, Beneficiary")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Customer, Pending, Beneficiary")]
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

            // If No Bill Exists Redirect To index
            if(paymentViewModel.Bill == null)
            {
                return RedirectToAction("Index", "Customer");
            }

            return View(paymentViewModel);
        }


        [HttpPost]
        public IActionResult MakePayment(PaymentViewModel model)
        {
            System.Diagnostics.Debug.WriteLine(model);
            Payment newPayment = new Payment()
            {
                PaymentMUID = Guid.NewGuid(),
                //PaymentMUID = model.Payment.PaymentMUID,
                BillMUID = model.Bill.BillMUID,
                PaidDate = DateTime.Now,
                Amount = model.Payment.Amount,
                CVV = model.Payment.CVV,
                PaymentMethod = model.Payment.PaymentMethod,
                PayerFirstName = model.Payment.PayerFirstName,
                PayerLastName = model.Payment.PayerLastName,
                CardNumber = model.Payment.CardNumber,
                ZipCode = model.Payment.ZipCode,
                CardExpireDate = model.Payment.CardExpireDate,
                DebitOrCredit = model.Payment.DebitOrCredit,
                BankName = model.Payment.BankName,
                AccountNumber = model.Payment.AccountNumber,
                RoutingNumber = model.Payment.RoutingNumber,
                CheckNumber = model.Payment.CheckNumber,
                CheckImage = model.Payment.CheckImage,
                AdditionalInfo = model.Payment.AdditionalInfo,
                CreatedDate = model.Payment.CreatedDate,
            };
            System.Diagnostics.Debug.WriteLine(newPayment);

            PaymentRepository.InsertPayment(newPayment);
            PaymentRepository.Save();
            Thread.Sleep(5000);

            Bill newBill = new Bill()
            {
                BillMUID = model.Bill.BillMUID,
                PolicyMUID = model.Policy.PolicyMUID,
                PolicyDueDate = model.Bill.PolicyDueDate,
                MinimumPayment = model.Bill.MinimumPayment,
                CreatedDate = DateTime.Now,
                Balance = model.Bill.Balance,
                Status = "Paid",
            };
            System.Diagnostics.Debug.WriteLine(newBill);

            BillRepository.UpdateBill(newBill);
            BillRepository.Save();
            Thread.Sleep(5000);


            Transaction newTransaction = new Transaction()
            {
                TransactionMUID = Guid.NewGuid(),
                CustomerMUID = model.Policy.CustomerMUID,
                PolicyMUID = model.Policy.PolicyMUID,
                isPaymentComplete = false,
                PaymentAmount = model.Payment.Amount,
                PaymentDate = DateTime.Now,
            };
            TransactionRepository.InsertTransaction(newTransaction);
            TransactionRepository.Save();
            return RedirectToAction("Index", "Customer");
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
