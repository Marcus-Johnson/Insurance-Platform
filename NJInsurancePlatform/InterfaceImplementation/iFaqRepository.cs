using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.InterfaceImplementation
{
    public interface iFaqRepository : IDisposable
    {
        Task<IEnumerable<Faq>> GetFaqs();
        Task<Faq> GetFaqsByID(Guid FaqMUID);

        void InsertFaq(Faq faq);
        void DeleteFaq(Guid FaqMUID);
        void UpdateFaq(Faq faq);
        void Save();
    }
}
