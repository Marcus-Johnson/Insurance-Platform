using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface IProductRepository : IDisposable
    {
        Task<IEnumerable<Product>> GetPolicies();
        Task<Product> GetPoliciesByID(Guid ProductMUID);

        void InsertPolicy(Product product);
        void DeletePolicy(Guid ProductMUID);
        void UpdatePolicy(Product product);
        void Save();
    }
}
