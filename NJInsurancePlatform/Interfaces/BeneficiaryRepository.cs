using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class BeneficiaryRepository : iBeneficiaryRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed = false;

        public BeneficiaryRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<IEnumerable<Beneficiary>> GetBeneficiaries()
        {
            return _databaseContext.Beneficiaries.ToList();
        }

        public async Task<Customer> GetBeneficiariesByID(Guid CustomerMUID)
        {
            var customer = await _databaseContext.Customers.FindAsync(CustomerMUID);
            return customer;
        }

        public async void InsertBeneficiary(Beneficiary beneficiary)
        {
            await _databaseContext.Beneficiaries.AddAsync(beneficiary);
        }

        public async void DeleteBeneficiary(Guid BeneficiaryMUID)
        {
            var BeneficiaryRemove = _databaseContext.Beneficiaries.FirstOrDefault(p => p.BeneficiaryMUID == BeneficiaryMUID);
            _databaseContext.Beneficiaries.Remove(BeneficiaryRemove);
        }

        public async void UpdateBeneficiary(Beneficiary beneficiary)
        {
            try
            {
                _databaseContext.Update(beneficiary);
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
