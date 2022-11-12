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
            var transactions =  await _transactionRepository.GetTransactions();
            var model = new AccountManager();

            foreach(var transaction in transactions)
            {
                model.Transactions?.Add(transaction);
            }

            return View(model);
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
            return View(model);
        }


        // ACCESS DENIED "GET REQUEST" ---------------------------------------------------------------------------------------------------------
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
