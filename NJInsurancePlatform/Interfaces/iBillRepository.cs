using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public interface IBillRepository : IDisposable
    {
        IEnumerable<Bill> GetBills();

        Bill GetBillsByID(Guid BillMUID);

        void InsertBill(Bill bill);

        void DeleteBill(Guid bill);

        void UpdateBill(Bill bill);

        void Save();
    }
}
