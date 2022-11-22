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
        private bool disposed = false;
        public PolicyRepository(InsuranceCorpDbContext databaseContext)
        {
            this._databaseContext = databaseContext;
            this.disposed = false;
        }

        public async Task<List<Policy>> GetPolicies()
        {
            return _databaseContext.Policies.ToList();
        }

        //public async Task<Customer> GetPoliciesByID(Guid PolicyMUID)
        //{
        //    var customer = await _databaseContext.Customers.FindAsync(PolicyMUID);
        //    return customer;
        //}

        public async void InsertPolicy(Policy policy)
        {
            await _databaseContext.Policies.AddAsync(policy);
        }

        public async void DeletePolicy(Guid PolicyMUID)
        {
            var policyRemove = _databaseContext.Policies.FirstOrDefault(p => p.PolicyMUID == PolicyMUID);
            _databaseContext.Policies.Remove(policyRemove);
        }

        public async Task UpdatePolicy(Policy policy)
        {
            try
            {
                Debug.WriteLine("trying");

               _databaseContext.Policies.Update(policy);
            }
            catch (DbUpdateConcurrencyException)
            {
                Debug.WriteLine("Caught");
                throw;
            }
        }

        public void Save()
        {
            _databaseContext.SaveChanges();
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