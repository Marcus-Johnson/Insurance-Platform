using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface ICustomerRepository : IDisposable
    {
        Task<IEnumerable<Customer>> GetCustomer();
        Task<Customer> GetCustomerById(Guid CustomerMUID);
        
        void InsertCustomer(Customer customer);
        void DeleteCustomer(Guid CustomerMUID);
        void UpdateCustomer(Customer customer);
        void Save();
    }
}
