using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public interface iBillRepository
    {
        Task<IEnumerable<Bill>> GetBills();

        Task<Bill> GetBillsByID(Guid BillMUID);

        void InsertBill(Bill bill);

        void DeleteBill(Guid bill);

        void UpdateBill(Bill bill);

        void Save();
    }
}
