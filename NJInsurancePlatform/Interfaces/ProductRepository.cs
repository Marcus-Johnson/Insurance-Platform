using Microsoft.EntityFrameworkCore;
using NJInsurancePlatform.Data;
using NJInsurancePlatform.InterfaceImplementation;
using NJInsurancePlatform.Models;
using System;

namespace NJInsurancePlatform.Interfaces
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private readonly InsuranceCorpDbContext _databaseContext;
        private bool disposed;

        public ProductRepository(InsuranceCorpDbContext databaseContext)
        {
            _databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        public async Task<IEnumerable<Product>> GetPolicies()
            => await _databaseContext.Products.ToListAsync();

        public async Task<Product> GetPoliciesByID(Guid ProductMUID)
            => await _databaseContext.Products.FindAsync(ProductMUID);

        public async Task InsertPolicy(Product product)
            => await _databaseContext.Products.AddAsync(product ?? throw new ArgumentNullException(nameof(product)));

        public async Task DeletePolicy(Guid ProductMUID)
        {
            var policyRemove = await _databaseContext.Products.FirstOrDefaultAsync(p => p.ProductMUID == ProductMUID);
            _databaseContext.Products.Remove(policyRemove != null ? policyRemove : throw new ArgumentNullException(nameof(policyRemove)));
        }

        public async Task UpdatePolicy(Product product)
        {
            try
            {
                _databaseContext.Update(product ?? throw new ArgumentNullException(nameof(product)));
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

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
