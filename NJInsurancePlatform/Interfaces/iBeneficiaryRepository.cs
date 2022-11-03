using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public interface IBeneficiaryRepository: IDisposable
    {
        IEnumerable<Beneficiary> GetBeneficiaries();

        Customer GetBeneficiariesByID(Guid CustomerMUID);

        void InsertBeneficiary(Beneficiary beneficiary);

        void DeleteBeneficiary(Guid BeneficiaryMUID);

        void UpdateBeneficiary(Beneficiary beneficiary);

        void Save();
    }
}
