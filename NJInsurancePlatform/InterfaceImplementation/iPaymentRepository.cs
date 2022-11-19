using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface IPaymentRepository : IDisposable
    {
        Task<IEnumerable<Payment>> GetPayment();

        Task<Payment> GetPaymentsByID(Guid PaymentMUID);

        void InsertPayment(Payment payment);

        void DeletePayment(Guid PaymentMUID);

        void UpdatePayment(Payment payment);

        void Save();
    }
}
