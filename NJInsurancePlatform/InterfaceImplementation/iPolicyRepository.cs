using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface IPolicyRepository : IDisposable
    {
        Task<List<Policy>> GetPolicies();

        //Task<Customer> GetPoliciesByID(Guid PolicyMUID);

        void InsertPolicy(Policy policy);

        void DeletePolicy(Guid PolicyMUID);

        Task UpdatePolicy(Policy policy);

        void Save();
    }
}