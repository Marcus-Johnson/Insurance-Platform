using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface IPolicyRepository : IDisposable
    {
        Task<List<Policy>> GetPolicies();
        Task UpdatePolicy(Policy policy);
        //Task<Customer> GetPoliciesByID(Guid PolicyMUID);

        void InsertPolicy(Policy policy);
        void DeletePolicy(Guid PolicyMUID);
        void Save();
    }
}
