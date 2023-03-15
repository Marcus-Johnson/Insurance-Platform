using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface ITransactionRepository : IDisposable
    {
        Task<List<Transaction>> GetTransactions();
        Task<Transaction> GetTransactionsByID(Guid TransactionMUID);

        void InsertTransaction(Transaction transaction);
        void DeleteTransaction(Guid TransactionMUID);
        void UpdateTransaction(Transaction transaction);
        void Save();
    }
}
