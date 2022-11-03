using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Repositories
{
    public interface ICustomerRepository
    {
        Task <IEnumerable<Customer>> GetCustomer();
        Task<Customer> GetCustomerById(Guid CustomerMUID);
        void InsertCustomer(Customer customer);
        void DeleteCustomer(Guid CustomerMUID);
        void UpdateCustomer(Customer customer);
        void Save();
    }
}
