using NJInsurancePlatform.Models;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using System;
using NJInsurancePlatform.InterfaceImplementation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NJInsurancePlatform.Interfaces
{
    public class ClaimRepository : IClaimRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _dbContext;

        public ClaimRepository(InsuranceCorpDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<Claim>> GetAllClaimsAsync()
        {
            return await _dbContext.Claims?.ToListAsync();
        }

        public async Task<Claim> GetClaimByIdAsync(Guid claimId)
        {
            return await _dbContext.Claims?.FindAsync(claimId);
        }

        public async Task AddClaimAsync(Claim claim)
        {
            await _dbContext.Claims?.AddAsync(claim);
        }

        public void RemoveClaim(Claim claim)
        {
            _dbContext.Claims?.Remove(claim);
        }

        public void UpdateClaim(Claim claim)
        {
            _dbContext?.Update(claim);
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
