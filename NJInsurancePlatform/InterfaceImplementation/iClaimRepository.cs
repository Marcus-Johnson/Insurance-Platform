using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface iClaimRepository : IDisposable
    {
        Task<IEnumerable<Claim>> GetClaims();
        Task<Claim> GetClaimsByID(Guid ClaimMUID);

        void InsertClaim(Claim claim);
        void DeleteClaim(Guid GroupMUID);
        void UpdateClaim(Claim claim);
        void Save();
    }
}
