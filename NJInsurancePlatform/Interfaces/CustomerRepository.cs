using NJInsurancePlatform.Models;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using System;
using NJInsurancePlatform.InterfaceImplementation;
using System.Threading.Tasks;

namespace NJInsurancePlatform.Interfaces
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _dbContext;
        private bool disposed;

        public CustomerRepository(InsuranceCorpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetCustomer()
            => await _dbContext.Customers.ToListAsync();

        public async Task<Customer> GetCustomerById(Guid CustomerMUID)
            => await _dbContext.Customers.FindAsync(CustomerMUID);

        public async Task InsertCustomer(Customer customer)
            => await _dbContext.Customers.AddAsync(customer ?? throw new ArgumentNullException(nameof(customer)));

        public async Task DeleteCustomer(Guid CustomerMUID)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(p => p.CustomerMUID == CustomerMUID);
            _dbContext.Customers.Remove(customer != null ? customer : throw new ArgumentNullException(nameof(customer)));
        }

        public async Task UpdateCustomer(Customer customer)
            => _dbContext.Update(customer ?? throw new ArgumentNullException(nameof(customer)));

        public async Task Save()
            => await _dbContext.SaveChangesAsync();

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing) _dbContext.Dispose();
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
