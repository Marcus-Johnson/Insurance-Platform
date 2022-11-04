using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Interfaces
{
    public class BillRepository : iBillRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        public BillRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<IEnumerable<Bill>> GetBills()
        {
            return _databaseContext.Bills.ToList();
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
