using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class TransactionRepository : ITransactionRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;

        public TransactionRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
            return await _databaseContext.Transactions.ToListAsync();
        }

        public async Task<Transaction> GetTransactionsByID(Guid TransactionMUID)
        {
            var transaction = await _databaseContext.Transactions.FindAsync(TransactionMUID);
            return transaction;
        }

        public async void InsertTransaction(Transaction transaction)
        {
            await _databaseContext.Transactions.AddAsync(transaction);
        }

        public async void DeleteTransaction(Guid TransactionMUID)
        {
            var removeTransaction = await _databaseContext.Transactions.FirstOrDefaultAsync(p => p.TransactionMUID == TransactionMUID);
            _databaseContext.Transactions.Remove(removeTransaction);
        }

        public async void UpdateTransaction(Transaction transaction)
        {
            try
            {
                _databaseContext.Update(transaction);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public async void Save()
        {
            await _databaseContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
