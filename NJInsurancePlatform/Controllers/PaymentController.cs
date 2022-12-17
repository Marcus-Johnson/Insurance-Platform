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
        private readonly IProductRepository _productRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public PaymentController(IProductRepository productRepository, ILogger<PaymentController> logger, IPolicyRepository PolicyRepository, ITransactionRepository TransactionRepository, iBillRepository BillRepository, IPaymentRepository PaymentRepository, UserManager<ApplicationUser> userManager)
        {
            this.PolicyRepository = PolicyRepository;
            this.TransactionRepository = TransactionRepository;
            this.BillRepository = BillRepository;
            this.PaymentRepository = PaymentRepository;
            this._productRepository = productRepository;
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
        public async Task<IActionResult> MakePayment(Guid policyId, Guid billId)
        {

            var allPolicies = await PolicyRepository.GetPolicies();
            var identityUser = User.Identity.Name;
            var user = await userManager.FindByNameAsync(identityUser);
            Policy getPolicy = allPolicies.FirstOrDefault(p => p.PolicyMUID == policyId);
            var Bills = await BillRepository.GetBills();
            Bill getBillbyID = Bills.FirstOrDefault(b => b.BillMUID == billId);
            var userBills = Bills.FindAll(b => b.CustomerMUID == user.CustomerMUID);
            
            PaymentViewModel paymentViewModel = new PaymentViewModel() 
            { 
                Policy = getPolicy,
                ApplicationUser = user,
                Bill = getBillbyID,
                Bills = userBills,
            };

            // If No Bill Exists Redirect To index
            if(paymentViewModel.Bill == null)
            {
                return RedirectToAction("Index", "Customer");
            }

            return View(paymentViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> MakePayment(PaymentViewModel model)
        {
            var products = await _productRepository.GetPolicies();
            var currentProduct = products.FirstOrDefault(p => p.ProductMUID == model.Policy.ProductMUID);
            var minimumPayment = (decimal)currentProduct.Price / 12;
            var minimumPaymentRound = Decimal.Round(minimumPayment, 2);
            var identityUser = User.Identity.Name;
            var user = await userManager.FindByNameAsync(identityUser);
            var totalPayments = 0;

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
            //System.Diagnostics.Debug.WriteLine(newPayment);

            PaymentRepository.InsertPayment(newPayment);
            PaymentRepository.Save();
            Thread.Sleep(5000);

            var currentBalance = Math.Round(model.Bill.Balance, 2);
            var currentPayment = Math.Round(model.Payment.Amount, 2);

            // Update Current Bill
            Bill currentBill = new Bill()
            {
                BillMUID = model.Bill.BillMUID,
                CustomerMUID = (Guid)user.CustomerMUID,
                PolicyMUID = model.Policy.PolicyMUID,
                PolicyDueDate = model.Bill.PolicyDueDate,
                MinimumPayment = (double)minimumPaymentRound,
                CreatedDate = DateTime.Now,
                Balance = currentBalance - currentPayment,
                Status = "Paid",
            };
            //System.Diagnostics.Debug.WriteLine(newBill);

            BillRepository.UpdateBill(currentBill);
            BillRepository.Save();
            Thread.Sleep(5000);

            // 
            var allBills = await BillRepository.GetBills();
            var updatedBill = allBills.FirstOrDefault(b => b.BillMUID == model.Bill.BillMUID);
            var balance = updatedBill.Balance;
            var roundedBalance = Math.Round(balance, 2);

            // Create new Bill With Pending Status For Future Payments
            Bill newBill = new Bill()
            {
                BillMUID = Guid.NewGuid(),
                CustomerMUID = (Guid)user.CustomerMUID,
                PolicyMUID = model.Policy.PolicyMUID,
                PolicyDueDate = model.Bill.PolicyDueDate.AddDays(30),
                MinimumPayment = (double)minimumPaymentRound,
                CreatedDate = DateTime.Now,
                Balance = roundedBalance,
                Status = "Due",
            };
            //System.Diagnostics.Debug.WriteLine(newBill);

            BillRepository.InsertBill(newBill);
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


            // BELOW NEEDS TO BE MOVED TO TRANSACTION APPROVAL CONTROLLER /////////////////////////////////////
            // Pull From Transactions Again After Updates Have Been Made
            var allTransactons = await TransactionRepository.GetTransactions();

            // Get Total Payments made From Transactions
            foreach (var transaction in allTransactons)
            {
                if(transaction.CustomerMUID == user.CustomerMUID && transaction.PolicyMUID == model.Policy.PolicyMUID)
                {
                    totalPayments += (int)transaction.PaymentAmount;
                }
            }

            // BELOW NEEDS TO BE MOVED TO TRANSACTION APPROVAL CONTROLLER
            // Set Policy Payment Due Status to False
            // Update Policy Paid Off Amount
            Policy updatePolicy = new Policy
            {
                PolicyMUID = model.Policy.PolicyMUID,
                ProductMUID = model.Policy.ProductMUID,
                CustomerMUID = model.Policy.CustomerMUID,
                NameOfPolicy = model.Policy.NameOfPolicy,
                PolicyOwner = model.Policy.PolicyOwner,
                Deductible = model.Policy.Deductible,
                OutOfPocketLimit = model.Policy.OutOfPocketLimit,
                AnnualLimitOfCoverage = model.Policy.AnnualLimitOfCoverage,
                PolicyPaymentisDue = false,
                PolicyTotalAmount = model.Policy.PolicyTotalAmount,
                PolicyPaidOffAmount = totalPayments,
                PolicyStart_Date = model.Policy.PolicyStart_Date,
                PolicyEnd_Date = model.Policy.PolicyEnd_Date,
                Pending = false,
            };
            PolicyRepository.UpdatePolicy(updatePolicy);
            PolicyRepository.Save();
            Thread.Sleep(5000);
            // MOVE TO TRANSACTION APPROVAL CONTROLLER ////////////////////////////////////////////////////////////////

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
