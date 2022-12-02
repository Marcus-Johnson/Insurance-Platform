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
        private bool disposed = false;

        public TransactionRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<List<Transaction>> GetTransactions()
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
             _databaseContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _databaseContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
