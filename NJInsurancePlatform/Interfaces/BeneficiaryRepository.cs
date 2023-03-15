using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.Interfaces;
using NJInsurancePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NJInsurancePlatform.InterfaceImplementations
{
    public class BeneficiaryRepository : IBeneficiaryRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _dbContext;

        public BeneficiaryRepository(InsuranceCorpDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<Beneficiary>> GetAllBeneficiariesAsync()
        {
            return await _dbContext.Beneficiaries?.ToListAsync();
        }

        public async Task<Customer> GetBeneficiaryByIdAsync(Guid beneficiaryId)
        {
            return await _dbContext.Customers?.FindAsync(beneficiaryId);
        }

        public async Task AddBeneficiaryAsync(Beneficiary beneficiary)
        {
            await _dbContext.Beneficiaries?.AddAsync(beneficiary);
        }

        public void RemoveBeneficiary(Beneficiary beneficiary)
        {
            _dbContext.Beneficiaries?.Remove(beneficiary);
        }

        public void UpdateBeneficiary(Beneficiary beneficiary)
        {
            _dbContext?.Update(beneficiary);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext?.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
