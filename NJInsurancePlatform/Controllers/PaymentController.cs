using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NJInsurancePlatform.InterfaceImplementation;
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

        public PaymentController(ILogger<PaymentController> logger, IPolicyRepository PolicyRepository, ITransactionRepository TransactionRepository, iBillRepository BillRepository, IPaymentRepository PaymentRepository)
        {
            this.PolicyRepository = PolicyRepository;
            this.TransactionRepository = TransactionRepository;
            this.BillRepository = BillRepository;
            this.PaymentRepository = PaymentRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MakePayment()
        {
            return View();
        }


        [HttpPost]
        public IActionResult MakePayment(Payment model)
        {
            return View();
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
