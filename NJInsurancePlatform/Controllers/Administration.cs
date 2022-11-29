using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Interfaces;
using NJInsurancePlatform.Models;
using System.Diagnostics;

namespace NJInsurancePlatform.Controllers
{
    public partial class AdministrationController
    {

        // GET PAID TRANSACTIONS "GET REQUEST" ------------------------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> UnpaidTransactions()                           
        {

            var transactions =  await _transactionRepository.GetTransactions();             // get Transactions from Database
            var model = new AccountManager();

            foreach(var transaction in transactions)                                        // populate AccountManager Transactions List
            {
                if(transaction.isPaymentComplete == false)
                {
                    model.Transactions?.Add(transaction);
                }
            }

            if (model.Transactions?.Count == 0 || model.Transactions == null) return RedirectToAction("AllPaymentsComplete", "Administration");

            return View(model);                                                             // Pass AccountManager to View
        }


        // GET PAID TRANSACTIONS "GET POST" ------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> UnpaidTransactions(AccountManager model)
        {

            for (int i = 0; i < model.Transactions?.Count; i++)
            {
                if(model.Transactions[i].isPaymentComplete == true)
                {
                    _transactionRepository.UpdateTransaction(model.Transactions[i]);            // Update transactions
                }

                if (i < (model.Transactions.Count - 1)) continue;                           // If iteration is not complete

                else
                {
                    _transactionRepository.Save();
                }
            }

            return RedirectToAction("UpdateRecorded", "Administration");
        }


        // GET PAID TRANSACTIONS "GET REQUEST" ------------------------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> PaidTransactions()
        {
            var transactions = await _transactionRepository.GetTransactions();               // get Transactions from Database
            var model = new AccountManager();

            foreach (var transaction in transactions)                                        // populate AccountManager Transactions List
            {
                if (transaction.isPaymentComplete == true)
                {
                    model.Transactions?.Add(transaction);
                }
            }

            if (model.Transactions?.Count == 0 || model.Transactions == null) return RedirectToAction("NoPaymentsComplete", "Administration");

            return View(model);                                                             // Pass AccountManager to View
        }


        // GET PAID TRANSACTIONS "GET POST" ------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> PaidTransactions(AccountManager model)
        {

            for (int i = 0; i < model.Transactions?.Count; i++)
            {
                if (model.Transactions[i].isPaymentComplete == false)
                {
                    _transactionRepository.UpdateTransaction(model.Transactions[i]);            // Update transactions
                }

                if (i < (model.Transactions.Count - 1)) continue;                           // If iteration is not complete

                else
                {
                    _transactionRepository.Save();
                }
            }

            return RedirectToAction("UpdateRecorded", "Administration");
        }



        // ACCESS DENIED "GET REQUEST" ---------------------------------------------------------------------------------------------------------
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }


        // ALL PAYMENTS COMPLETE "GET REQUEST" ---------------------------------------------------------------------------------------------------------
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AllPaymentsComplete()
        {
            return View();
        }


        // ALL PAYMENTS COMPLETE "GET REQUEST" ---------------------------------------------------------------------------------------------------------
        [HttpGet]
        [AllowAnonymous]
        public IActionResult NoPaymentsComplete()
        {
            return View();
        }


        // COMPLETE PAYMENT RECORDED "GET REQUEST" ---------------------------------------------------------------------------------------------------------
        [HttpGet]
        [AllowAnonymous]
        public IActionResult UpdateRecorded()
        {
            return View();
        }
    }
}
