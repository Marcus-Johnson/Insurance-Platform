using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.Interfaces;
using NJInsurancePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NJInsurancePlatform.InterfaceImplementations
{
    public class BillRepository : IBillRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _dbContext;

        public BillRepository(InsuranceCorpDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<Bill>> GetAllBillsAsync()
        {
            return await _dbContext.Bills?.ToListAsync();
        }

        public async Task<Bill> GetBillByIdAsync(Guid billId)
        {
            return await _dbContext.Bills?.FindAsync(billId);
        }

        public async Task AddBillAsync(Bill bill)
        {
            await _dbContext.Bills?.AddAsync(bill);
        }

        public void RemoveBill(Bill bill)
        {
            _dbContext.Bills?.Remove(bill);
        }

        public void UpdateBill(Bill bill)
        {
            _dbContext?.Update(bill);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext?.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
