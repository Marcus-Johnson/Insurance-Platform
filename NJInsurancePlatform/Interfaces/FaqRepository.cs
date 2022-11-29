using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class FaqRepository : iFaqRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed = false;

        public FaqRepository(InsuranceCorpDbContext _databaseContent)
        {
            this._databaseContext = _databaseContent;
        }

        public async Task<IEnumerable<Faq>> GetFaqs()
        {
            return _databaseContext.Faqs.ToList();
        }
        
        public async Task<Faq> GetFaqsByID(Guid FaqMUID)
        {
            var faq = await _databaseContext.Faqs.FindAsync(FaqMUID);
            return faq;
        }
        
        public async void InsertFaq(Faq faq)
        {
            await _databaseContext.Faqs.AddAsync(faq);
        }
        
        public async void DeleteFaq(Guid FaqMUID)
        {
            var faqRemove = _databaseContext.Faqs.FirstOrDefault(p => p.FaqMUID == FaqMUID);
            _databaseContext.Faqs.Remove(faqRemove);
        }
        
        public async void UpdateFaq(Faq faq)
        {
            try
            {
                 _databaseContext.Update(faq);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        
        public async void Save()
        {
            await _databaseContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _databaseContext.Dispose();
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
