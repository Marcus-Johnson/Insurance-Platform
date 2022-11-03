using NJInsurancePlatform.Models;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using System;

namespace NJInsurancePlatform.Repositories
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _dbContext;
        public CustomerRepository(InsuranceCorpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET ALL ACTION
        public async Task<IEnumerable<Customer>> GetCustomer()
        {
            return await _dbContext.Customers.ToListAsync();
        }

        // GET BY ID ACTION
        public async Task<Customer> GetCustomerById(Guid CustomerMUID)
        {
            var customer = await _dbContext.Customers.FindAsync(CustomerMUID);
            return customer;
        }
        // ADD ACTION
        public async void InsertCustomer(Customer customer)
        {
            await _dbContext.Customers.AddAsync(customer);
        }
        // DELETE ACTION
        public async void DeleteCustomer(Guid CustomerMUID)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(p => p.CustomerMUID == CustomerMUID);
            _dbContext.Customers.Remove(customer);
        } 
        // UPDATE ACTION
        public async void UpdateCustomer(Customer customer)
        {
            try
            {
                _dbContext.Update(customer);
            }
            catch
            {
                throw;
            }
        }
        // SAVE ACTION
        public async void Save()
        {
            await _dbContext.SaveChangesAsync();
        }
        // DISPOSE NOT IN USE
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
