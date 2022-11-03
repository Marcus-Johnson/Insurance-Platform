using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Interfaces
{
    public class PolicyRepository : iPolicyRepository
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        public async Task<IEnumerable<Policy>> GetPolicies()
        {
            return _databaseContext.Policies.ToList();
        }
        public async Task<Customer> GetPoliciesByID(Guid PolicyMUID)
        {
            var customer = await _databaseContext.Customers.FindAsync(PolicyMUID);
            return customer;
        }
        public async void InsertPolicy(Policy policy)
        {
            await _databaseContext.Policies.AddAsync(policy);
        }
        public async void DeletePolicy(Guid PolicyMUID)
        {
            var policyRemove = _databaseContext.Policies.FirstOrDefault(p => p.PolicyMUID == PolicyMUID);
            _databaseContext.Policies.Remove(policyRemove);
        }
        public async void UpdatePolicy(Policy policy)
        {
            try
            {
                 _databaseContext.Update(policy);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async void Save()
        {
            await _databaseContext.SaveChangesAsync();
        }
    }
}
