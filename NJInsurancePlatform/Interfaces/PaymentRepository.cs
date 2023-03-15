using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Interfaces
{
    public class PaymentRepository : IPaymentRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed;

        public PaymentRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        public async Task<IEnumerable<Payment>> GetPayment()
            => await _databaseContext.Payments.ToListAsync();

        public async Task<Payment> GetPaymentsByID(Guid PaymentMUID)
            => await _databaseContext.Payments.FindAsync(PaymentMUID);

        public async Task InsertPayment(Payment payment)
            => await _databaseContext.Payments.AddAsync(payment ?? throw new ArgumentNullException(nameof(payment)));

        public async Task DeletePayment(Guid PaymentMUID)
        {
            var removePayment = await _databaseContext.Payments.FirstOrDefaultAsync(p => p.PaymentMUID == PaymentMUID);
            _databaseContext.Payments.Remove(removePayment != null ? removePayment : throw new ArgumentNullException(nameof(removePayment)));
        }

        public async Task UpdatePayment(Payment payment)
            => _databaseContext.Update(payment ?? throw new ArgumentNullException(nameof(payment)));

        public async Task Save()
            => await _databaseContext.SaveChangesAsync();

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing) _databaseContext.Dispose();
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
