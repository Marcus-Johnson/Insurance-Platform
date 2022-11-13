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
            //var custGuid = new Guid();
            //var policyGuid = new Guid();
            //DateTime date = DateTime.Now;

            //var addTransaction = new Transaction()
            //{
            //    CustomerMUID = custGuid,
            //    PolicyMUID =    policyGuid,
            //    isPaymentComplete = false,
            //    PaymentAmount = 1287.29,
            //    PaymentDate = date,
            //};

            //_transactionRepository.InsertTransaction(addTransaction);
            //_transactionRepository.Save();

            var transactions =  await _transactionRepository.GetTransactions();             // get Transactions from Database
            var model = new AccountManager();

            foreach(var transaction in transactions)                                        // populate AccountManager Transactions List
            {
                if(transaction.isPaymentComplete == false)
                {
                    model.Transactions?.Add(transaction);
                }
            }

            if (model.Transactions?.Count == 0 || model.Transactions == null) return RedirectToAction("Administration", "AllTransactionsPaid");

            return View(model);                                                             // Pass AccountManager to View
        }


        // GET PAID TRANSACTIONS "GET POST" ------------------------------------------------------------------------------------------------------
        [HttpPost]
        public async Task<IActionResult> UnpaidTransactions(AccountManager model)
        {
            for (int i = 0; i < model.Transactions?.Count; i++)
            {
                _transactionRepository.UpdateTransaction(model.Transactions[i]);            // Update transaction

                if (i < (model.Transactions.Count - 1)) continue;                           // If iteration is not complete

                else
                {
                    _transactionRepository.Save();
                }
            }

            var transactions = await _transactionRepository.GetTransactions();
            foreach (var transaction in transactions)
            {
                if(transaction.isPaymentComplete == false)
                {
                    model.Transactions?.Add(transaction);
                }
                if(model.Transactions?.Count == 0)
                {
                    return RedirectToAction("Administration","AllTransactionsPaid");
                }
            }
            return View(model);
        }


        // ACCESS DENIED "GET REQUEST" ---------------------------------------------------------------------------------------------------------
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult AllTransactionsPaid()
        {
            return View();
        }
    }
}
