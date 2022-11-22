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
        private bool disposed = false;
        public ProductRepository(InsuranceCorpDbContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public async Task<IEnumerable<Product>> GetPolicies()
        {
            return await _databaseContext.Products.ToListAsync();
        }

        public async Task<Product> GetPoliciesByID(Guid ProductMUID)
        {
            var product = await _databaseContext.Products.FindAsync(ProductMUID);
            return product;
        }

        public async void InsertPolicy(Product product)
        {
            await _databaseContext.Products.AddAsync(product);
        }

        public async void DeletePolicy(Guid ProductMUID)
        {
            var policyRemove = _databaseContext.Products.FirstOrDefault(p => p.ProductMUID == ProductMUID);
            _databaseContext.Products.Remove(policyRemove);
        }

        public async void UpdatePolicy(Product product)
        {
            try
            {
                _databaseContext.Update(product);
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