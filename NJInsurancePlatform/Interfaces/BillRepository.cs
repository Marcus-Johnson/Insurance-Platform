using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Interfaces
{
    public class BillRepository : iBillRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed = false;

        public BillRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<Bill>> GetBills()
        {
            return await _databaseContext.Bills.ToListAsync();
        }

        public async Task<Bill> GetBillsByID(Guid BillMUID)
        {
            var bill = await _databaseContext.Bills.FindAsync(BillMUID);
            return bill;
        }

        public async void InsertBill(Bill bill)
        {
            await _databaseContext.Bills.AddAsync(bill);
        }

        public async void DeleteBill(Guid bill)
        {
            var billRemove = _databaseContext.Bills.FirstOrDefault(p => p.BillMUID == bill);
            _databaseContext.Bills.Remove(billRemove);
        }

        public async void UpdateBill(Bill bill)
        {
            try
            {
                _databaseContext.Update(bill);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void Save()
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
