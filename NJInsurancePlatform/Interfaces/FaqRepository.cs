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
        private bool disposed;

        public FaqRepository(InsuranceCorpDbContext _databaseContent)
        {
            this._databaseContext = _databaseContent ?? throw new ArgumentNullException(nameof(_databaseContent));
        }

        public async Task<IEnumerable<Faq>> GetFaqs()
            => await _databaseContext.Faqs.ToListAsync();
        
        public async Task<Faq> GetFaqsByID(Guid FaqMUID)
            => await _databaseContext.Faqs.FindAsync(FaqMUID);
        
        public async Task InsertFaq(Faq faq)
            => await _databaseContext.Faqs.AddAsync(faq ?? throw new ArgumentNullException(nameof(faq)));
        
        public async Task DeleteFaq(Guid FaqMUID)
        {
            var faqRemove = await _databaseContext.Faqs.FirstOrDefaultAsync(p => p.FaqMUID == FaqMUID);
            _databaseContext.Faqs.Remove(faqRemove != null ? faqRemove : throw new ArgumentNullException(nameof(faqRemove)));
        }
        
        public async Task UpdateFaq(Faq faq)
            => _databaseContext.Update(faq ?? throw new ArgumentNullException(nameof(faq)));

        public async Task Save()
            => await _databaseContext.SaveChangesAsync();

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing) _databaseContext.Dispose();
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
