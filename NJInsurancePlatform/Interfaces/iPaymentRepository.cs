using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public interface IPaymentRepository : IDisposable
    {
        IEnumerable<Payment> GetPayment();

        Payment GetPaymentsByID(Guid PaymentMUID);

        void InsertPayment(Payment payment);

        void DeletePayment(Guid PaymentMUID);

        void UpdatePayment(Payment payment);

        void Save();
    }
}