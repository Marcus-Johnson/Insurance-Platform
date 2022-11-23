using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using NJInsurancePlatform.InterfaceImplementation;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using NJInsurancePlatform.Interfaces;
using Microsoft.AspNetCore.Http.Features;
//using NJInsurancePlatform.Repositories;


namespace NJInsurancePlatform.Controllers
{
    [AllowAnonymous] //WHILE 
    public class BillController : Controller
    {
        private readonly IPolicyRepository PolicyRepository;
        private readonly ITransactionRepository TransactionRepository;
        private readonly iBillRepository BillRepository;
        private readonly IPaymentRepository PaymentRepository;

        public BillController(IPolicyRepository PolicyRepository, ITransactionRepository TransactionRepository, iBillRepository BillRepository, IPaymentRepository PaymentRepository)
        {
            this.PolicyRepository = PolicyRepository;
            this.TransactionRepository = TransactionRepository;
            this.BillRepository = BillRepository;
            this.PaymentRepository = PaymentRepository;
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


        //protected override void Dispose(bool disposing)
        //{
        //    PolicyRepository.Dispose();
        //    TransactionRepository.Dispose():
        //    BillRepository.Dispose();
        //    PaymentRepository.Dispose();
        //    base.Dispose(disposing);
        //}

    }
}

