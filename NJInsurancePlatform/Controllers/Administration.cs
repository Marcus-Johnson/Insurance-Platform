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

                for (int i = 0; i < allTransactions.Count; i++)
                {
                    // is transaction already present in the list?
                    var transactionAllReadyThere = allTransactionsViewModel.Transactions.Exists(t => t.TransactionMUID == allTransactions[i].TransactionMUID);

                    if (allTransactions[i].isPaymentComplete == true || allTransactions[i].isPaymentComplete == false)
                    {
                        // if not present in the list, add it.    
                        if (!transactionAllReadyThere)
                        {
                            // Match Policies, and Transactions by MUID numbers
                            var userByTransaction = allUsers.FirstOrDefault(u => u.CustomerMUID == allTransactions[i].CustomerMUID && u.BeneficiaryMUID == null && u.FirstName != null);
                            var policyByTransaction = allPolicies.FirstOrDefault(p => p.PolicyMUID == allTransactions[i].PolicyMUID);

                            // insert items into corresponding index locations in there respective lists
                            allTransactionsViewModel.Policies.Insert(i, policyByTransaction);
                            allTransactionsViewModel.ApplicationUsers.Insert(i, userByTransaction);
                            allTransactionsViewModel.Transactions.Insert(i, allTransactions[i]);

                            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>> " + findUserById.FirstName + " ApplicationUser # " + i);
                            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>> " + policyByTransaction.PolicyOwner + " Policy Owner " + i);
                            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>> " + policyByTransaction.PolicyMUID + " Policy Number " + i);
                            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>> " + allTransactions[i].PolicyMUID + " Policy Number# " + i);

                            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>> " + allTransactionsViewModel.ApplicationUsers[i].FirstName + " ApplicationUser # " + i);
                            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>> " + allTransactionsViewModel.Policies[i].PolicyOwner + " Policy Name " + i);
                            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>> " + allTransactionsViewModel.Policies[i].PolicyMUID + " Policy Number From Policy" + i);
                            //System.Diagnostics.Debug.WriteLine(">>>>>>>>>>>>>>>> " + allTransactions[i].PolicyMUID + " Policy Number From Transaction " + i);

                        }

                    }

                }

                return View("TransactionSearchResults", allTransactionsViewModel);
            }



            // Return Only Paid transactions
            if (keywords == null && ispaid == true && getall == false)
            {
                // Filter only paid transactions
                var onlyPaidTransactions = allTransactions.Where(t => t.isPaymentComplete == true).ToList();

                for (int i = 0; i < onlyPaidTransactions.Count; i++)
                {
                    // is transaction already present in the list?
                    var transactionAllReadyThere = allTransactionsViewModel.Transactions.Exists(t => t.TransactionMUID == onlyPaidTransactions[i].TransactionMUID);

                    // if not present in the list, add it.    
                    if (!transactionAllReadyThere)
                    {
                        // Match Policies, and Transactions by MUID numbers
                        var userByTransaction = allUsers.FirstOrDefault(u => u.CustomerMUID == onlyPaidTransactions[i].CustomerMUID && u.BeneficiaryMUID == null && u.FirstName != null);
                        var policyByTransaction = allPolicies.FirstOrDefault(p => p.PolicyMUID == onlyPaidTransactions[i].PolicyMUID);

                        // insert items into corresponding index locations in there respective lists
                        allTransactionsViewModel.Policies.Insert(i, policyByTransaction);
                        allTransactionsViewModel.ApplicationUsers.Insert(i, userByTransaction);
                        allTransactionsViewModel.Transactions.Insert(i, onlyPaidTransactions[i]);
                    }
                }

                return View("TransactionSearchResults", allTransactionsViewModel);
            }

            // Return Unpaid transactions
            if (keywords == null && ispaid == false && getall == false)
            {
                // Filter only paid transactions
                var UnPaidTransactions = allTransactions.Where(t => t.isPaymentComplete == false).ToList();

                for (int i = 0; i < UnPaidTransactions.Count; i++)
                {
                    // is transaction already present in the list?
                    var transactionAllReadyThere = allTransactionsViewModel.Transactions.Exists(t => t.TransactionMUID == UnPaidTransactions[i].TransactionMUID);

                    // if not present in the list, add it.    
                    if (!transactionAllReadyThere)
                    {
                        // Match Policies, and Transactions by MUID numbers
                        var userByTransaction = allUsers.FirstOrDefault(u => u.CustomerMUID == UnPaidTransactions[i].CustomerMUID && u.BeneficiaryMUID == null && u.FirstName != null);
                        var policyByTransaction = allPolicies.FirstOrDefault(p => p.PolicyMUID == UnPaidTransactions[i].PolicyMUID);

                        // insert items into corresponding index locations in there respective lists
                        allTransactionsViewModel.Policies.Insert(i, policyByTransaction);
                        allTransactionsViewModel.ApplicationUsers.Insert(i, userByTransaction);
                        allTransactionsViewModel.Transactions.Insert(i, UnPaidTransactions[i]);
                    }
                }

                return View("TransactionSearchResults", allTransactionsViewModel);
            }



            else if (keywords != null)
            {
                string[] inputKeywords = keywords.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);         // Create An array from input fields

                List<ApplicationUser> matchingUsers = new List<ApplicationUser>();

                for (int i = 0; i < inputKeywords.Count(); i++)          // Loop through keywords array
                {
                    var matchingUser = allUsers.FirstOrDefault(u => u.FirstName.ToLower() == inputKeywords[i].ToLower() || u.LastName.ToLower() == inputKeywords[i].ToLower());       // If match is found

                    if (matchingUser != null)
                    {
                        var userAlreadyInList = allTransactionsViewModel.ApplicationUsers.Exists(u => u.CustomerMUID == matchingUser.CustomerMUID);                    // Check If user is On The List

                        if (!userAlreadyInList)
                        {
                            matchingUsers.Add(matchingUser);
                        }
                    }

                }

                // Now that we have some possible matches, loop through array to find matching transactions
                for (int i = 0; i < matchingUsers.Count; i++)
                {
                    // Iterate Through All Transactions For each User To find a Match
                    for (int j = 0; j < allTransactions.Count; j++)
                    {
                        var transactionAlreadyInList = allTransactionsViewModel.Transactions.Exists(t => t.TransactionMUID == allTransactions[j].TransactionMUID);

                        if (allTransactions[j].CustomerMUID == matchingUsers[i].CustomerMUID && !transactionAlreadyInList)
                        {
                            // Now that we found transactions that match this customer, we can find the policies that match this transaction
                            var findPolicyByTransaction = allPolicies.FirstOrDefault(p => p.PolicyMUID == allTransactions[j].PolicyMUID);

                            allTransactionsViewModel.ApplicationUsers.Add(matchingUsers[i]);
                            allTransactionsViewModel.Policies.Add(findPolicyByTransaction);
                            allTransactionsViewModel.Transactions.Add(allTransactions[j]);

                        }

                    }

                }

            }
            //        var keywordsNOspace = String.Concat(keywords.Where(c => !Char.IsWhiteSpace(c))).ToLower();
            //        if (user.FirstName != null && user.FirstName.Contains(keywords, StringComparison.OrdinalIgnoreCase) ||


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


        // COMPLETE PAYMENT RECORDED "GET REQUEST" ---------------------------------------------------------------------------------------------------------
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult UpdateRecorded()
        {
            return View();
        }
    }
}