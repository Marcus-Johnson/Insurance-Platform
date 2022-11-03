using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Interfaces
{
    public interface iPolicyRepository
    {
        Task<IEnumerable<Policy>> GetPolicies();

        Task<Customer> GetPoliciesByID(Guid PolicyMUID);

        void InsertPolicy(Policy policy);

        void DeletePolicy(Guid PolicyMUID);

        void UpdatePolicy(Policy policy);

        void Save();
    }
}
