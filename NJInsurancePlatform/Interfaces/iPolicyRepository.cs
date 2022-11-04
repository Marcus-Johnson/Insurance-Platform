using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public interface iPolicyRepository : IDisposable
    {
        Task<IEnumerable<Policy>> GetPolicies();

        Task<Customer> GetPoliciesByID(Guid PolicyMUID);

        void InsertPolicy(Policy policy);

        void DeletePolicy(Guid PolicyMUID);

        void UpdatePolicy(Policy policy);

        void Save();
    }
}
