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
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> SearchAllTransactions()
        {
            return View();                                                             // Pass AccountManager to View
        }


        // GET PAID TRANSACTIONS "GET POST" ------------------------------------------------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> TransactionSearch(string keywords, bool ispaid, bool getall)
        {
            var allUsers = userManager.Users.Where(u => u.FirstName != null && u.LastName != null);
            var allTransactions = await _transactionRepository.GetTransactions();
            var allPolicies = await _policyRepository.GetPolicies();

            var allTransactionsViewModel = new AllTransactionsViewModel();


            // retreive all records based on check status
            if (keywords == null && ispaid == false && getall == true)
            {
                foreach (var user in allUsers)
                {
                    foreach (var transaction in allTransactions)
                    {
                        foreach (var policy in allPolicies)
                        {

                            // exclude beneficiaries and check for "isPaymentComplete" status"
                            if (user.CustomerMUID == transaction.CustomerMUID && policy.CustomerMUID == user.CustomerMUID && user.BeneficiaryMUID == null)
                            {
                                allTransactionsViewModel.ApplicationUsers.Add(user);
                                allTransactionsViewModel.Transactions.Add(transaction);
                                allTransactionsViewModel.Policies.Add(policy);
                            }
                        }
                    }
                }

                return View("TransactionSearchResults", allTransactionsViewModel);
            }

            // if user input is Blank, retreive all records based on check status
            if (keywords == null)
            {
                foreach (var user in allUsers)
                {
                    foreach (var transaction in allTransactions)
                    {
                        foreach (var policy in allPolicies)
                        {

                            // exclude beneficiaries and check for "isPaymentComplete" status"
                            if (user.CustomerMUID == transaction.CustomerMUID && policy.CustomerMUID == user.CustomerMUID && transaction.isPaymentComplete == ispaid && user.BeneficiaryMUID == null)
                            {
                                allTransactionsViewModel.ApplicationUsers.Add(user);
                                allTransactionsViewModel.Transactions.Add(transaction);
                                allTransactionsViewModel.Policies.Add(policy);
                            }
                        }
                    }
                }

                return View("TransactionSearchResults", allTransactionsViewModel);
            }


            // if user input is not blank
            else if (keywords != null)
            {

                // Validate user input Search Input
                foreach (var user in allUsers)
                {
                    // remove all white space and to lowercase variables
                    var keywordsNOspace = String.Concat(keywords.Where(c => !Char.IsWhiteSpace(c))).ToLower();
                    var firstLast = user.FirstName + user.LastName;
                    var firstLastLowerCase = firstLast.ToLower();

                    // only get users with a first and last name
                    if (user.FirstName != null && user.FirstName.Contains(keywords, StringComparison.OrdinalIgnoreCase) ||
                        user.LastName != null && user.LastName.Contains(keywords, StringComparison.OrdinalIgnoreCase) ||
                        user.FirstName != null && user.LastName != null && keywordsNOspace == firstLastLowerCase)
                    {
                        //allTransactionsViewModel.ApplicationUsers.Add(user);

                        foreach (var transaction in allTransactions)
                        {
                            foreach (var policy in allPolicies)
                            {
                                if (transaction.CustomerMUID == user.CustomerMUID && policy.CustomerMUID == user.CustomerMUID && transaction.isPaymentComplete == ispaid)
                                {
                                    allTransactionsViewModel.ApplicationUsers.Add(user);
                                    allTransactionsViewModel.Transactions.Add(transaction);
                                    allTransactionsViewModel.Policies.Add(policy);

                                }
                            }

                        }

                    }
                }

            }

            return View("TransactionSearchResults", allTransactionsViewModel);
        }


        // GET PAID TRANSACTIONS "GET POST" ------------------------------------------------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateTransactionStatus(AllTransactionsViewModel model)
        {
            for (int i = 0; i < model.Transactions?.Count; i++)
            {

                var updatedTransaction = new Transaction()
                {
                    TransactionMUID = model.Transactions[i].TransactionMUID,
                    CustomerMUID = model.Transactions[i].CustomerMUID,
                    PolicyMUID = model.Transactions[i].PolicyMUID,
                    isPaymentComplete = model.Transactions[i].isPaymentComplete,
                    PaymentAmount = model.Transactions[i].PaymentAmount,
                    PaymentDate = model.Transactions[i].PaymentDate
                };
                _transactionRepository.UpdateTransaction(updatedTransaction);            // Update transactions


                if (i < (model.Transactions.Count - 1)) continue;                           // If iteration is not complete

                else
                {
                    _transactionRepository.Save();
                }
            }


            return View("UpdateRecorded", "Administration");
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