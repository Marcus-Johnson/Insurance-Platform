using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface iBillRepository : IDisposable
    {
        Task<List<Bill>> GetBills();

        Task<Bill> GetBillsByID(Guid BillMUID);

        void InsertBill(Bill bill);

        void DeleteBill(Guid bill);

        void UpdateBill(Bill bill);

        void Save();
    }
}
