using System;
using System.Collections.Generic;
using NJInsurancePlatform.Models;

namespace NJInsurancePlatform.Interfaces
{
    public interface IPolicyRepository : IDisposable
    {
        IEnumerable<Policy> GetPolicies();

        Customer GetPoliciesByID(Guid PolicyMUID);

        void InsertPolicy(Policy policy);

        void DeletePolicy(Guid PolicyMUID);

        void UpdatePolicy(Policy policy);

        void Save();
    }
}
