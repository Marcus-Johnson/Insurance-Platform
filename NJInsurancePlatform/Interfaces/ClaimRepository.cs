using NJInsurancePlatform.Models;
using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using System;
using NJInsurancePlatform.InterfaceImplementation;

namespace NJInsurancePlatform.Interfaces
{
    public class ClaimRepository : iClaimRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _dbContext;
        private bool disposed = false;

        public ClaimRepository(InsuranceCorpDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<Claim>> GetClaims()
        {
            return await _dbContext.Claims.ToListAsync();
        }


        public async Task<Claim> GetClaimsByID(Guid ClaimMUID)
        {
            var claim = await _dbContext.Claims.FindAsync(ClaimMUID);
            return claim;
        }

        public async void InsertClaim(Claim claim)
        {
            await _dbContext.Claims.AddAsync(claim);
        }

        public async void DeleteClaim(Guid GroupMUID)
        {
            var claim = await _dbContext.Claims.FirstOrDefaultAsync(p => p.ClaimMUID == GroupMUID);
            _dbContext.Claims.Remove(claim);
        }

        public async void UpdateClaim(Claim claim)
        {
            try
            {
                _dbContext.Update(claim);
            }
            catch
            {
                throw;
            }
        }

        public async void Save()
        {
            await _dbContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
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
