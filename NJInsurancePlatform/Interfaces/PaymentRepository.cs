using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Interfaces
{
    public class PaymentRepository : IPaymentRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        public PaymentRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<IEnumerable<Payment>> GetPayment()
        {
            return await _databaseContext.Payments.ToListAsync();
        }

        public async Task<Payment> GetPaymentsByID(Guid PaymentMUID)
        {
            var payment = await _databaseContext.Payments.FindAsync(PaymentMUID);
            return payment;
        }

        public async void InsertPayment(Payment payment)
        {
            await _databaseContext.Payments.AddAsync(payment);
        }

        public async void DeletePayment(Guid PaymentMUID)
        {
            var removePayment = await _databaseContext.Payments.FirstOrDefaultAsync(p => p.PaymentMUID == PaymentMUID);
            _databaseContext.Payments.Remove(removePayment);
        }

        public async void UpdatePayment(Payment payment)
        {
            try
            {
                _databaseContext.Update(payment);
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
