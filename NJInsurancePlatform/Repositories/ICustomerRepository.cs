using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Repositories
{
    public interface ICustomerRepository<TEntity, DataType> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetCustomers();
        Task<TEntity> GetCustomer(DataType CustomerMUID);
        Task<TEntity> InsertCustomer(TEntity entity);
        Task<TEntity> DeleteCustomer(DataType CustomerMUID);
        Task<TEntity> UpdateCustomer(TEntity entity);
        Task Save();
    }
}
