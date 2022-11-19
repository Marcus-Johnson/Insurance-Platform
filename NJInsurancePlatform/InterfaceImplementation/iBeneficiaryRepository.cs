using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface iBeneficiaryRepository  : IDisposable
    {
        Task<IEnumerable<Beneficiary>> GetBeneficiaries();

        Task<Customer> GetBeneficiariesByID(Guid CustomerMUID);

        void InsertBeneficiary(Beneficiary beneficiary);

        void DeleteBeneficiary(Guid BeneficiaryMUID);

        void UpdateBeneficiary(Beneficiary beneficiary);

        void Save();
    }
}
