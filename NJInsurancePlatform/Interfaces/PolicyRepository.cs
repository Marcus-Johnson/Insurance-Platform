using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class PolicyRepository : IPolicyRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed = false;
        public PolicyRepository(InsuranceCorpDbContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public async Task<List<Policy>> GetPolicies()
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

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _databaseContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}