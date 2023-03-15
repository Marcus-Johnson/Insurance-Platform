using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System;
using System.Diagnostics;

namespace NJInsurancePlatform.Interfaces
{
    public class PolicyRepository : IPolicyRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed;

        public PolicyRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        public async Task<List<Policy>> GetPolicies()
            => await _databaseContext.Policies.ToListAsync();

        public async Task InsertPolicy(Policy policy)
            => await _databaseContext.Policies.AddAsync(policy ?? throw new ArgumentNullException(nameof(policy)));

        public async Task DeletePolicy(Guid PolicyMUID)
        {
            var policyRemove = await _databaseContext.Policies.FirstOrDefaultAsync(p => p.PolicyMUID == PolicyMUID);
            _databaseContext.Policies.Remove(policyRemove != null ? policyRemove : throw new ArgumentNullException(nameof(policyRemove)));
        }

        public async Task UpdatePolicy(Policy policy)
        {
            try
            {
                Debug.WriteLine("trying");

                _databaseContext.Update(policy ?? throw new ArgumentNullException(nameof(policy)));
            }
            catch (DbUpdateConcurrencyException)
            {
                Debug.WriteLine("Caught");
                throw;
            }
        }

        public async Task Save()
            => await _databaseContext.SaveChangesAsync();

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing) _databaseContext.Dispose();
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
