using NJInsurancePlatform.Models;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;

namespace NJInsurancePlatform.Repositories
{
    public class CustomerRepository : ICustomerRepository<Customer, Guid>
    {
        private readonly InsuranceCorpDbContext _dbContext;
        public CustomerRepository(InsuranceCorpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET ALL ACTION
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _dbContext.Customers.ToListAsync();
        }
        // GET BY ID ACTION
        public async Task<Customer> GetCustomer(Guid id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            return customer;
        }
        // ADD ACTION
        public async Task<Customer> InsertCustomer(Customer entity)
        {
            await _dbContext.Customers.AddAsync(entity);
            return entity;
        }
        // DELETE ACTION
        public async Task<Customer> DeleteCustomer(Guid id)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(p => p.CustomerMUID == id);
            _dbContext.Customers.Remove(customer);
            return customer;
        } 
        // UPDATE ACTION
        public async Task<Customer> UpdateCustomer(Customer entity)
        {
            try
            {
                _dbContext.Update(entity);
            }
            catch
            {
                throw;
            }
            return entity;
        }
        // SAVE ACTION
        public async void Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
