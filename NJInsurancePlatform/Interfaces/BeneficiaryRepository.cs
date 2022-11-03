using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Interfaces
{
    public class BeneficiaryRepository: iBeneficiaryRepository
    {
        private readonly InsuranceCorpDbContext _databaseContext;

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
    }
}
