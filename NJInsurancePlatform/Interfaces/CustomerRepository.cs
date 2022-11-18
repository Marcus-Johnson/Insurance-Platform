using NJInsurancePlatform.Models;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using System;
using NJInsurancePlatform.InterfaceImplementation;

namespace NJInsurancePlatform.Interfaces
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly InsuranceCorpDbContext _dbContext;
        private bool disposed = false;
        
        public CustomerRepository(InsuranceCorpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public async Task<IEnumerable<Customer>> GetCustomer()
        {
            return await _dbContext.Customers.ToListAsync();
        }

        
        public async Task<Customer> GetCustomerById(Guid CustomerMUID)
        {
            var customer = await _dbContext.Customers.FindAsync(CustomerMUID);
            return customer;
        }
        
        public async void InsertCustomer(Customer customer)
        {
            await _dbContext.Customers.AddAsync(customer);
        }
        
        public async void DeleteCustomer(Guid CustomerMUID)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(p => p.CustomerMUID == CustomerMUID);
            _dbContext.Customers.Remove(customer);
        }
        
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
        
        public async void Save()
        {
            await _dbContext.SaveChangesAsync();
        }
        
        //protected virtual void Dispose(bool disposing)
        //{
            //if (!this.disposed)
            //{
                //if (disposing)
                //{
                    //context.Dispose();
                //}
            //}
            //this.disposed = true;
        //}

        //public void Dispose()
        //{
            //Dispose(true);
            //GC.SuppressFinalize(this);
        //}
    }
}
